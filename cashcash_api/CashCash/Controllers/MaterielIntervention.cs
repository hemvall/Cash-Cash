using cashcash_api.Context;
using CashCash.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Item.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MaterielInterventionController : ControllerBase
    {
        private readonly CashCashContext _cashcashContext;

        public MaterielInterventionController(CashCashContext cashcashContext)
        {
            _cashcashContext = cashcashContext;
        }
        
        [HttpGet("{id:int}", Name = "GetMaterielInterventions")]
        public ActionResult<MaterielIntervention> Get(int id)
        {
            var a = _cashcashContext.MaterielIntervention?.AsNoTracking().FirstOrDefault(x => x.MaterielId == id || x.InterventionId == id);
            return a is null ? NotFound() : a;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MaterielIntervention>> Get()
        {
            var exs = _cashcashContext.MaterielIntervention?.AsNoTracking().ToList();
            return exs is null ? NotFound() : exs;
        }

        [HttpPost]
        public ActionResult<MaterielIntervention> Post(MaterielIntervention ex)
        {
            if(ex is null) return BadRequest();

            _cashcashContext.MaterielIntervention?.Add(ex);
            _cashcashContext.SaveChanges();

            return new CreatedAtRouteResult("GetMaterielIntervention", new { id = ex.InterventionId, ex.MaterielId});
        }

        [HttpDelete("{cId:int}, {mId:int}")]
        public IActionResult Delete(int cId, int mId)
        {
            var a = _cashcashContext.MaterielIntervention?.FirstOrDefault(c => c.InterventionId == cId && c.MaterielId == mId);

            if(a is null) return NotFound();

            _cashcashContext.MaterielIntervention?.Remove(a);
            _cashcashContext.SaveChanges();

            return Ok(a);
        }
    }
}