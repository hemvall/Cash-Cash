using cashcash_api.Context;
using CashCash.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Item.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MaterielController : ControllerBase
    {
        private readonly CashCashContext _cashcashContext;

        public MaterielController(CashCashContext cashcashContext)
        {
            _cashcashContext = cashcashContext;
        }

        [HttpGet("{NumSerie:int}", Name = "GetMateriels")]
        public ActionResult<Materiel> Get(int NumSerie)
        {
            var a = _cashcashContext.matériel?.AsNoTracking().FirstOrDefault(x => x.NumSerie == NumSerie);
            return a is null ? NotFound() : a;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Materiel>> Get()
        {
            var exs = _cashcashContext.matériel?.AsNoTracking().ToList();
            return exs is null ? NotFound() : exs;
        }

        [HttpPost]
        public ActionResult<Materiel> Post(Materiel ex)
        {
            if (ex is null) return BadRequest();

            _cashcashContext.matériel?.Add(ex);
            _cashcashContext.SaveChanges();

            return new CreatedAtRouteResult("GetMateriel", new { ex.NumSerie, ex });
        }

        [HttpPut("{NumSerie:int}")]
        public ActionResult<Materiel> Put(int NumSerie, Materiel ex)
        {
            if (ex is null || ex.NumSerie != NumSerie) return BadRequest();

            _cashcashContext.Entry(ex).State = EntityState.Modified;
            _cashcashContext.SaveChanges();

            return Ok(ex);
        }

        [HttpDelete("{NumSerie:int}")]
        public IActionResult Delete(int NumSerie)
        {
            var a = _cashcashContext.matériel?.FirstOrDefault(c => c.NumSerie == NumSerie);

            if (a is null) return NotFound();

            _cashcashContext.matériel?.Remove(a);
            _cashcashContext.SaveChanges();

            return Ok(a);
        }
    }
}