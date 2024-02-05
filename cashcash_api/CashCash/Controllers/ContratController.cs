using cashcash_api.Context;
using CashCash.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Item.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContratController : ControllerBase
    {
        private readonly CashCashContext _cashcashContext;

        public ContratController(CashCashContext cashcashContext)
        {
            _cashcashContext = cashcashContext;
        }

        [HttpGet("{id:int}", Name = "GetContrats")]
        public ActionResult<Contrat> Get(int id)
        {
            var a = _cashcashContext.Contrat?.AsNoTracking().FirstOrDefault(x => x.NumContrat == id);
            return a is null ? NotFound() : a;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Contrat>> Get()
        {
            var exs = _cashcashContext.Contrat?.AsNoTracking().ToList();
            return exs is null ? NotFound() : exs;
        }

        [HttpPost]
        public ActionResult<Contrat> Post(Contrat ex)
        {
            if (ex is null) return BadRequest();

            _cashcashContext.Contrat?.Add(ex);
            _cashcashContext.SaveChanges();

            return new CreatedAtRouteResult("GetContrat", new { id = ex.NumContrat, ex });
        }

        [HttpPut("{id:int}")]
        public ActionResult<Contrat> Put(int id, Contrat ex)
        {
            if (ex is null || ex.NumContrat != id) return BadRequest();

            _cashcashContext.Entry(ex).State = EntityState.Modified;
            _cashcashContext.SaveChanges();

            return Ok(ex);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var a = _cashcashContext.Contrat?.FirstOrDefault(c => c.NumContrat == id);

            if (a is null) return NotFound();

            _cashcashContext.Contrat?.Remove(a);
            _cashcashContext.SaveChanges();

            return Ok(a);
        }
    }
}