using cashcash_api.Context;
using CashCash.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;
using Org.BouncyCastle.Crypto.Generators;

namespace Users.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly CashCashContext _cashcashContext;

        public UsersController(CashCashContext cashcashContext)
        {
            _cashcashContext = cashcashContext;
        }

        static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        static bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }

        [HttpGet("{id:int}", Name = "GetUsers")]
        public ActionResult<User> Get(int id)
        {
            var a = _cashcashContext.User?.AsNoTracking().FirstOrDefault(x => x.Id == id);
            return a is null ? NotFound() : a;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            var exs = _cashcashContext.User?.AsNoTracking().ToList();
            return exs is null ? NotFound() : exs;
        }


        [HttpPost("Authentification")]
        public ActionResult<User> Authenticate(string mail, string password)
        {
            if (mail == null || password == null)
            {
                return BadRequest("Invalid login data.");
            }

            User user = _cashcashContext.User.FirstOrDefault(x => x.Mail == mail);

            if (user == null)
            {
                return NotFound("User not found.");
            }

            if (BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                return user;
            }
            else
            {
                return Unauthorized("Incorrect password.");
            }
        }

        [HttpPost("Register")]
        public ActionResult<User> Register(User newUser)
        {
            if (newUser == null)
            {
                return BadRequest("Invalid user data.");
            }

            // Hash the user's password before saving it to the database
            newUser.Password = HashPassword(newUser.Password);

            _cashcashContext.User.Add(newUser);
            _cashcashContext.SaveChanges();

            // Return the newly created user
            return new CreatedAtRouteResult("GetUser", new { id = newUser.Id }, newUser);
        }

        [HttpPost]
        public ActionResult<User> Post(User ex)
        {
            if(ex is null) return BadRequest();
            
            _cashcashContext.SaveChanges();

            return new CreatedAtRouteResult("GetUser", new { id = ex.Id, ex});
        }

        [HttpPut("{id:int}")]
        public ActionResult<User> Put(int id, User ex)
        {
            if(ex is null || ex.Id != id) return BadRequest();

            _cashcashContext.Entry<User>(ex).State = EntityState.Modified;
            _cashcashContext.SaveChanges();

            return Ok(ex);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var a = _cashcashContext.User?.FirstOrDefault(c => c.Id == id);

            if(a is null) return NotFound();

            _cashcashContext.User?.Remove(a);
            _cashcashContext.SaveChanges();

            return Ok(a);
        }
    }
}