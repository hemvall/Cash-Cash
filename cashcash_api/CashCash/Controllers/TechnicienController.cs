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

        [HttpGet("{id:int}", Name = "GetTechniciens")]
        public ActionResult<Technicien> Get(int id)
        {
            var a = _cashcashContext.Technicien?.AsNoTracking().FirstOrDefault(x => x.TechId == id);
            return a is null ? NotFound() : a;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Technicien>> Get()
        {
            var exs = _cashcashContext.Technicien?.AsNoTracking().ToList();
            return exs is null ? NotFound() : exs;
        }

        [HttpPost]
        public ActionResult<Technicien> Post(Technicien ex)
        {
            if (ex is null) return BadRequest();

            _cashcashContext.Technicien?.Add(ex);
            _cashcashContext.SaveChanges();

            return new CreatedAtRouteResult("GetTechnicien", new { id = ex.TechId, ex });
        }

        [HttpPut("{id:int}")]
        public ActionResult<Technicien> Put(int id, Technicien ex)
        {
            if (ex is null || ex.TechId != id) return BadRequest();

            _cashcashContext.Entry(ex).State = EntityState.Modified;
            _cashcashContext.SaveChanges();

            return Ok(ex);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var a = _cashcashContext.Technicien?.FirstOrDefault(c => c.TechId == id);

            if (a is null) return NotFound();

            _cashcashContext.Technicien?.Remove(a);
            _cashcashContext.SaveChanges();

            return Ok(a);
        }
    }
}