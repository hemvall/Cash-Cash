using cashcash_api.Context;
using CashCash.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Item.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TechnicienController : ControllerBase
    {
        private readonly CashCashContext _cashcashContext;

        public TechnicienController(CashCashContext cashcashContext)
        {
            _cashcashContext = cashcashContext;
        }

        [HttpGet("{NumEmploye:int}", Name = "GetTechniciens")]
        public ActionResult<Technicien> Get(int NumEmploye)
        {
            var a = _cashcashContext.technicien?.AsNoTracking().FirstOrDefault(x => x.NumEmploye == NumEmploye);
            return a is null ? NotFound() : a;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Technicien>> Get()
        {
            var exs = _cashcashContext.technicien?.AsNoTracking().ToList();
            return exs is null ? NotFound() : exs;
        }

        [HttpPost]
        public ActionResult<Technicien> Post(Technicien ex)
        {
            if (ex is null) return BadRequest();

            _cashcashContext.technicien?.Add(ex);
            _cashcashContext.SaveChanges();

            return new CreatedAtRouteResult("GetTechnicien", new { id = ex.NumEmploye, ex });
        }

        [HttpPut("{NumEmploye:int}")]
        public ActionResult<Technicien> Put(int NumEmploye, Technicien ex)
        {
            if (ex is null || ex.NumEmploye != NumEmploye) return BadRequest();

            _cashcashContext.Entry(ex).State = EntityState.Modified;
            _cashcashContext.SaveChanges();

            return Ok(ex);
        }

        [HttpDelete("{NumEmploye:int}")]
        public IActionResult Delete(int NumEmploye)
        {
            var a = _cashcashContext.technicien?.FirstOrDefault(c => c.NumEmploye == NumEmploye);

            if (a is null) return NotFound();

            _cashcashContext.technicien?.Remove(a);
            _cashcashContext.SaveChanges();

            return Ok(a);
        }
    }
}