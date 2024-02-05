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

        [HttpGet("{id:int}", Name = "GetMateriels")]
        public ActionResult<Materiel> Get(int id)
        {
            var a = _cashcashContext.Materiel?.AsNoTracking().FirstOrDefault(x => x.NumSerie == id);
            return a is null ? NotFound() : a;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Materiel>> Get()
        {
            var exs = _cashcashContext.Materiel?.AsNoTracking().ToList();
            return exs is null ? NotFound() : exs;
        }

        [HttpPost]
        public ActionResult<Materiel> Post(Materiel ex)
        {
            if (ex is null) return BadRequest();

            _cashcashContext.Materiel?.Add(ex);
            _cashcashContext.SaveChanges();

            return new CreatedAtRouteResult("GetMateriel", new { id = ex.NumSerie, ex });
        }

        [HttpPut("{id:int}")]
        public ActionResult<Materiel> Put(int id, Materiel ex)
        {
            if (ex is null || ex.NumSerie != id) return BadRequest();

            _cashcashContext.Entry(ex).State = EntityState.Modified;
            _cashcashContext.SaveChanges();

            return Ok(ex);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var a = _cashcashContext.Materiel?.FirstOrDefault(c => c.NumSerie == id);

            if (a is null) return NotFound();

            _cashcashContext.Materiel?.Remove(a);
            _cashcashContext.SaveChanges();

            return Ok(a);
        }
    }
}