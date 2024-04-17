using cashcash_api.Context;
using CashCash.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Item.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InterventionController : ControllerBase
    {
        private readonly CashCashContext _cashcashContext;

        public InterventionController(CashCashContext cashcashContext)
        {
            _cashcashContext = cashcashContext;
        }

        [HttpGet("{NumIntervention:int}", Name = "GetInterventions")]
        public ActionResult<Intervention> Get(int NumIntervention)
        {
            var a = _cashcashContext.intervention?.AsNoTracking().FirstOrDefault(x => x.NumIntervention == NumIntervention);
            return a is null ? NotFound() : a;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Intervention>> Get()
        {
            var exs = _cashcashContext.intervention?.AsNoTracking().ToList();
            return exs is null ? NotFound() : exs;
        }

        [HttpPost]
        public ActionResult<Intervention> Post(Intervention ex)
        {
            if (ex is null) return BadRequest();

            _cashcashContext.intervention?.Add(ex);
            _cashcashContext.SaveChanges();

            return new CreatedAtRouteResult("GetIntervention", new { NumIntervention = ex.NumIntervention, ex });
        }

        [HttpPut("{NumIntervention:int}")]
        public ActionResult<Intervention> Put(int NumIntervention, Intervention ex)
        {
            if (ex is null || ex.NumIntervention != NumIntervention) return BadRequest();

            _cashcashContext.Entry(ex).State = EntityState.Modified;
            _cashcashContext.SaveChanges();

            return Ok(ex);
        }

        [HttpDelete("{NumIntervention:int}")]
        public IActionResult Delete(int NumIntervention)
        {
            var a = _cashcashContext.intervention?.FirstOrDefault(c => c.NumIntervention == NumIntervention);

            if (a is null) return NotFound();

            _cashcashContext.intervention?.Remove(a);
            _cashcashContext.SaveChanges();

            return Ok(a);
        }
    }
}