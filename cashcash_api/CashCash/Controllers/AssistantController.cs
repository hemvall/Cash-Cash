using cashcash_api.Context;
using CashCash.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Item.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AsssistantController : ControllerBase
    {
        private readonly CashCashContext _cashcashContext;

        public AsssistantController(CashCashContext cashcashContext)
        {
            _cashcashContext = cashcashContext;
        }

        [HttpGet("{NumEmployeAssistant:int}", Name = "GetAssistant")]
        public ActionResult<Assistant> Get(int NumEmployeAssistant)
        {
            var a = _cashcashContext.assistant?.AsNoTracking().FirstOrDefault(x => x.NumEmploye == NumEmployeAssistant);
            return a is null ? NotFound() : a;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Assistant>> Get()
        {
            var exs = _cashcashContext.assistant?.AsNoTracking().ToList();
            return exs is null ? NotFound() : exs;
        }

        [HttpPost]
        public ActionResult<Assistant> Post(Assistant ex)
        {
            if (ex is null) return BadRequest();

            _cashcashContext.assistant?.Add(ex);
            _cashcashContext.SaveChanges();

            return new CreatedAtRouteResult("GetAssistant", new { NumEmploye = ex.NumEmploye, ex });
        }

        [HttpPut("{NumEmployeAssistant:int}")]
        public ActionResult<Assistant> Put(int NumEmployeAssistant, Assistant ex)
        {
            if (ex is null || ex.NumEmploye != NumEmployeAssistant) return BadRequest();

            _cashcashContext.Entry(ex).State = EntityState.Modified;
            _cashcashContext.SaveChanges();

            return Ok(ex);
        }

        [HttpDelete("{NumEmployeAssistant:int}")]
        public IActionResult Delete(int NumEmployeAssistant)
        {
            var a = _cashcashContext.assistant?.FirstOrDefault(c => c.NumEmploye == NumEmployeAssistant);

            if (a is null) return NotFound();

            _cashcashContext.assistant?.Remove(a);
            _cashcashContext.SaveChanges();

            return Ok(a);
        }
    }
}