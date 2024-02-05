using cashcash_api.Context;
using CashCash.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
/*using BCrypt.Net;
*/
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
        
        [HttpGet("{id:int}", Name = "GetUsers")]
        public ActionResult<User> Get(int id)
        {
            var a = _cashcashContext.Users?.AsNoTracking().FirstOrDefault(x => x.Id == id);
            return a is null ? NotFound() : a;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            var exs = _cashcashContext.Users?.AsNoTracking().ToList();
            return exs is null ? NotFound() : exs;
        }

        [HttpPost("Authentification")]
        public ActionResult<User> Authentification(User ex)
        {
            if (ex is null) return BadRequest();

            User usr = _cashcashContext.Users.FirstOrDefault(x => x.Mail == ex.Mail && x.Password == ex.Password);

            if (usr is null) return NotFound();

            return usr;
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
            var a = _cashcashContext.Users?.FirstOrDefault(c => c.Id == id);

            if(a is null) return NotFound();

            _cashcashContext.Users?.Remove(a);
            _cashcashContext.SaveChanges();

            return Ok(a);
        }
    }
}