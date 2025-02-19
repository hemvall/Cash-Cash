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

        [HttpGet("{NumClient:int}", Name = "GetClients")]
        public ActionResult<Client> Get(int NumClient)
        {
            var a = _cashcashContext.client?.AsNoTracking().FirstOrDefault(x => x.NumClient == NumClient);
            return a is null ? NotFound() : a;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Client>> Get()
        {
            var exs = _cashcashContext.client?.AsNoTracking().ToList();
            return exs is null ? NotFound() : exs;
        }

        [HttpPost]
        public ActionResult<Client> Post(Client ex)
        {
            if (ex is null) return BadRequest();

            _cashcashContext.client?.Add(ex);
            _cashcashContext.SaveChanges();

            return new CreatedAtRouteResult("GetClient", new { NumClient = ex.NumClient, ex });
        }

        [HttpPut("{NumClient:int}")]
        public ActionResult<Client> Put(int NumClient, Client ex)
        {
            if (ex is null || ex.NumClient != NumClient) return BadRequest();

            _cashcashContext.Entry(ex).State = EntityState.Modified;
            _cashcashContext.SaveChanges();

            return Ok(ex);
        }

        [HttpDelete("{NumClient:int}")]
        public IActionResult Delete(int NumClient)
        {
            var a = _cashcashContext.client?.FirstOrDefault(c => c.NumClient == NumClient);

            if (a is null) return NotFound();

            _cashcashContext.client?.Remove(a);
            _cashcashContext.SaveChanges();

            return Ok(a);
        }
    }
}