using cashcash_api.Context;
using CashCash.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Item.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContratMaterielController : ControllerBase
    {
        private readonly CashCashContext _cashcashContext;

        public ContratMaterielController(CashCashContext cashcashContext)
        {
            _cashcashContext = cashcashContext;
        }
        
        [HttpGet("{id:int}", Name = "GetContratMateriels")]
        public ActionResult<ContratMateriel> Get(int id)
        {
            var a = _cashcashContext.ContratMateriel?.AsNoTracking().FirstOrDefault(x => x.MaterielId == id || x.ContratId == id);
            return a is null ? NotFound() : a;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ContratMateriel>> Get()
        {
            var exs = _cashcashContext.ContratMateriel?.AsNoTracking().ToList();
            return exs is null ? NotFound() : exs;
        }

        [HttpPost]
        public ActionResult<ContratMateriel> Post(ContratMateriel ex)
        {
            if(ex is null) return BadRequest();

            _cashcashContext.ContratMateriel?.Add(ex);
            _cashcashContext.SaveChanges();

            return new CreatedAtRouteResult("GetContratMateriel", new { id = ex.ContratId, ex.MaterielId});
        }

        [HttpDelete("{cId:int}, {mId:int}")]
        public IActionResult Delete(int cId, int mId)
        {
            var a = _cashcashContext.ContratMateriel?.FirstOrDefault(c => c.ContratId == cId && c.MaterielId == mId);

            if(a is null) return NotFound();

            _cashcashContext.ContratMateriel?.Remove(a);
            _cashcashContext.SaveChanges();

            return Ok(a);
        }
    }
}