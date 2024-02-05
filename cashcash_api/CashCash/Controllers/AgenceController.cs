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
        
        [HttpGet("{id:int}", Name = "GetAgences")]
        public ActionResult<Agence> Get(int id)
        {
            var a = _cashcashContext.Agence?.AsNoTracking().FirstOrDefault(x => x.AgenceId == id);
            return a is null ? NotFound() : a;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Agence>> Get()
        {
            var exs = _cashcashContext.Agence?.AsNoTracking().ToList();
            return exs is null ? NotFound() : exs;
        }

        [HttpPost]
        public ActionResult<Agence> Post(Agence ex)
        {
            if(ex is null) return BadRequest();

            _cashcashContext.Agence?.Add(ex);
            _cashcashContext.SaveChanges();

            return new CreatedAtRouteResult("GetAgence", new { id = ex.AgenceId, ex});
        }

        [HttpPut("{id:int}")]
        public ActionResult<Agence> Put(int id, Agence ex)
        {
            if(ex is null || ex.AgenceId != id) return BadRequest();

            _cashcashContext.Entry(ex).State = EntityState.Modified;
            _cashcashContext.SaveChanges();

            return Ok(ex);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var a = _cashcashContext.Agence?.FirstOrDefault(c => c.AgenceId == id);

            if(a is null) return NotFound();

            _cashcashContext.Agence?.Remove(a);
            _cashcashContext.SaveChanges();

            return Ok(a);
        }
    }
}