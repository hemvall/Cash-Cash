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

        [HttpGet("{id:int}", Name = "GetInterventions")]
        public ActionResult<Intervention> Get(int id)
        {
            var a = _cashcashContext.Intervention?.AsNoTracking().FirstOrDefault(x => x.InterventionId == id);
            return a is null ? NotFound() : a;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Intervention>> Get()
        {
            var exs = _cashcashContext.Intervention?.AsNoTracking().ToList();
            return exs is null ? NotFound() : exs;
        }

        [HttpPost]
        public ActionResult<Intervention> Post(Intervention ex)
        {
            if (ex is null) return BadRequest();

            _cashcashContext.Intervention?.Add(ex);
            _cashcashContext.SaveChanges();

            return new CreatedAtRouteResult("GetIntervention", new { id = ex.InterventionId, ex });
        }

        [HttpPut("{id:int}")]
        public ActionResult<Intervention> Put(int id, Intervention ex)
        {
            if (ex is null || ex.InterventionId != id) return BadRequest();

            _cashcashContext.Entry(ex).State = EntityState.Modified;
            _cashcashContext.SaveChanges();

            return Ok(ex);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var a = _cashcashContext.Intervention?.FirstOrDefault(c => c.InterventionId == id);

            if (a is null) return NotFound();

            _cashcashContext.Intervention?.Remove(a);
            _cashcashContext.SaveChanges();

            return Ok(a);
        }
    }
}