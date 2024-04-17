using cashcash_api.Context;
using CashCash.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Item.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AgenceController : ControllerBase
    {
        private readonly CashCashContext _cashcashContext;

        public AgenceController(CashCashContext cashcashContext)
        {
            _cashcashContext = cashcashContext;
        }
        
        [HttpGet("{NumAgence:int}", Name = "GetAgences")]
        public ActionResult<Agence> Get(int NumAgence)
        {
            var a = _cashcashContext.agence?.AsNoTracking().FirstOrDefault(x => x.NumAgence == NumAgence);
            return a is null ? NotFound() : a;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Agence>> Get()
        {
            var exs = _cashcashContext.agence?.AsNoTracking().ToList();
            return exs is null ? NotFound() : exs;
        }

        [HttpPost]
        public ActionResult<Agence> Post(Agence ex)
        {
            if(ex is null) return BadRequest();

            _cashcashContext.agence?.Add(ex);
            _cashcashContext.SaveChanges();

            return new CreatedAtRouteResult("GetAgence", new { NumAgence = ex.NumAgence, ex});
        }

        [HttpPut("{NumAgence:int}")]
        public ActionResult<Agence> Put(int NumAgence, Agence ex)
        {
            if(ex is null || ex.NumAgence != NumAgence) return BadRequest();

            _cashcashContext.Entry(ex).State = EntityState.Modified;
            _cashcashContext.SaveChanges();

            return Ok(ex);
        }

        [HttpDelete("{NumAgence:int}")]
        public IActionResult Delete(int NumAgence)
        {
            var a = _cashcashContext.agence?.FirstOrDefault(c => c.NumAgence == NumAgence);

            if(a is null) return NotFound();

            _cashcashContext.agence?.Remove(a);
            _cashcashContext.SaveChanges();

            return Ok(a);
        }
    }
}