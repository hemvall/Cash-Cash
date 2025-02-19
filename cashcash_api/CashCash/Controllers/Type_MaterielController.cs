using cashcash_api.Context;
using CashCash.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Item.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Type_MaterielController : ControllerBase
    {
        private readonly CashCashContext _cashcashContext;

        public Type_MaterielController(CashCashContext cashcashContext)
        {
            _cashcashContext = cashcashContext;
        }

        [HttpGet("{Référence:int}", Name = "GetType_Materiel")]
        public ActionResult<Type_Materiel> Get(int Référence)
        {
            var a = _cashcashContext.type_matériel?.AsNoTracking().FirstOrDefault(x => x.Référence == Référence);
            return a is null ? NotFound() : a;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Type_Materiel>> Get()
        {
            var exs = _cashcashContext.type_matériel?.AsNoTracking().ToList();
            return exs is null ? NotFound() : exs;
        }

        [HttpPost]
        public ActionResult<Type_Materiel> Post(Type_Materiel ex)
        {
            if (ex is null) return BadRequest();

            _cashcashContext.type_matériel?.Add(ex);
            _cashcashContext.SaveChanges();

            return new CreatedAtRouteResult("GetType_Materiel", new { Référence = ex.Référence, ex });
        }

        [HttpPut("{Référence:int}")]
        public ActionResult<Type_Materiel> Put(int Référence, Type_Materiel ex)
        {
            if (ex is null || ex.Référence != Référence) return BadRequest();

            _cashcashContext.Entry(ex).State = EntityState.Modified;
            _cashcashContext.SaveChanges();

            return Ok(ex);
        }

        [HttpDelete("{Référence:int}")]
        public IActionResult Delete(int Référence)
        {
            var a = _cashcashContext.type_matériel?.FirstOrDefault(c => c.Référence == Référence);

            if (a is null) return NotFound();

            _cashcashContext.type_matériel?.Remove(a);
            _cashcashContext.SaveChanges();

            return Ok(a);
        }
    }
}