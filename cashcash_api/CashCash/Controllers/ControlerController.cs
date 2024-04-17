using cashcash_api.Context;
using CashCash.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Item.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ControlerController : ControllerBase
    {
        private readonly CashCashContext _cashcashContext;

        public ControlerController(CashCashContext cashcashContext)
        {
            _cashcashContext = cashcashContext;
        }
        
        [HttpGet("{NumSerieIntervention:int}, {NumIntervention:int}", Name = "GetControler")]
        public ActionResult<Controler> Get(int NumSerieIntervention, int NumIntervention)
        {
            var a = _cashcashContext.controler?.AsNoTracking().FirstOrDefault(x => x.NumSerie == NumSerieIntervention && x.NumIntervention == NumIntervention);
            return a is null ? NotFound() : a;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Controler>> Get()
        {
            var exs = _cashcashContext.controler?.AsNoTracking().ToList();
            return exs is null ? NotFound() : exs;
        }

        [HttpPost]
        public ActionResult<Controler> Post(Controler ex)
        {
            if(ex is null) return BadRequest();

            _cashcashContext.controler?.Add(ex);
            _cashcashContext.SaveChanges();

            return new CreatedAtRouteResult("GetControler", new { NumSerie = ex.NumSerie, ex.NumIntervention});
        }

        [HttpDelete("{NumSerieIntervention:int}, {NumSerie:int}")]
        public IActionResult Delete(int NumSerie, int NumIntervention)
        {
            var a = _cashcashContext.controler?.FirstOrDefault(c => c.NumSerie == NumSerie && c.NumIntervention == NumIntervention);

            if(a is null) return NotFound();

            _cashcashContext.controler?.Remove(a);
            _cashcashContext.SaveChanges();

            return Ok(a);
        }
    }
}