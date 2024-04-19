using cashcash_api.Context;
using CashCash.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Item.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeController : ControllerBase
    {
        private readonly CashCashContext _cashcashContext;

        public EmployeController(CashCashContext cashcashContext)
        {
            _cashcashContext = cashcashContext;
        }

        [HttpGet("{NumEmploye:int}", Name = "GetEmploye")]
        public ActionResult<Employe> Get(int NumEmploye)
        {
            var a = _cashcashContext.employé?.AsNoTracking().FirstOrDefault(x => x.NumEmploye == NumEmploye);
            return a is null ? NotFound() : a;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employe>> Get()
        {
            var exs = _cashcashContext.employé?.AsNoTracking().ToList();
            return exs is null ? NotFound() : exs;
        }

        [HttpPost]
        public ActionResult<Employe> Post(Employe ex)
        {
            if (ex is null) return BadRequest();

            _cashcashContext.employé?.Add(ex);
            _cashcashContext.SaveChanges();

            return new CreatedAtRouteResult("GetEmploye", new { NumEmploye = ex.NumEmploye});
        }

        [HttpDelete("{NumEmploye:int}")]
        public IActionResult Delete(int NumEmploye)
        {
            var a = _cashcashContext.employé?.FirstOrDefault(c => c.NumEmploye == NumEmploye);

            if (a is null) return NotFound();

            _cashcashContext.employé?.Remove(a);
            _cashcashContext.SaveChanges();

            return Ok(a);
        }
    }
}