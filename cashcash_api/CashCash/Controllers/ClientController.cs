using cashcash_api.Context;
using CashCash.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Item.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly CashCashContext _cashcashContext;

        public ClientController(CashCashContext cashcashContext)
        {
            _cashcashContext = cashcashContext;
        }

        [HttpGet("{id:int}", Name = "GetClients")]
        public ActionResult<Client> Get(int id)
        {
            var a = _cashcashContext.Client?.AsNoTracking().FirstOrDefault(x => x.ClientId == id);
            return a is null ? NotFound() : a;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Client>> Get()
        {
            var exs = _cashcashContext.Client?.AsNoTracking().ToList();
            return exs is null ? NotFound() : exs;
        }

        [HttpPost]
        public ActionResult<Client> Post(Client ex)
        {
            if (ex is null) return BadRequest();

            _cashcashContext.Client?.Add(ex);
            _cashcashContext.SaveChanges();

            return new CreatedAtRouteResult("GetClient", new { id = ex.ClientId, ex });
        }

        [HttpPut("{id:int}")]
        public ActionResult<Client> Put(int id, Client ex)
        {
            if (ex is null || ex.ClientId != id) return BadRequest();

            _cashcashContext.Entry(ex).State = EntityState.Modified;
            _cashcashContext.SaveChanges();

            return Ok(ex);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var a = _cashcashContext.Client?.FirstOrDefault(c => c.ClientId == id);

            if (a is null) return NotFound();

            _cashcashContext.Client?.Remove(a);
            _cashcashContext.SaveChanges();

            return Ok(a);
        }
    }
}