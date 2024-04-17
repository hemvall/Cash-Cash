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

        [HttpGet("{R�f�rence:int}", Name = "GetType_Materiel")]
        public ActionResult<Type_Materiel> Get(int R�f�rence)
        {
            var a = _cashcashContext.type_mat�riel?.AsNoTracking().FirstOrDefault(x => x.R�f�rence == R�f�rence);
            return a is null ? NotFound() : a;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Type_Materiel>> Get()
        {
            var exs = _cashcashContext.type_mat�riel?.AsNoTracking().ToList();
            return exs is null ? NotFound() : exs;
        }

        [HttpPost]
        public ActionResult<Type_Materiel> Post(Type_Materiel ex)
        {
            if (ex is null) return BadRequest();

            _cashcashContext.type_mat�riel?.Add(ex);
            _cashcashContext.SaveChanges();

            return new CreatedAtRouteResult("GetType_Materiel", new { R�f�rence = ex.R�f�rence, ex });
        }

        [HttpPut("{R�f�rence:int}")]
        public ActionResult<Type_Materiel> Put(int R�f�rence, Type_Materiel ex)
        {
            if (ex is null || ex.R�f�rence != R�f�rence) return BadRequest();

            _cashcashContext.Entry(ex).State = EntityState.Modified;
            _cashcashContext.SaveChanges();

            return Ok(ex);
        }

        [HttpDelete("{R�f�rence:int}")]
        public IActionResult Delete(int R�f�rence)
        {
            var a = _cashcashContext.type_mat�riel?.FirstOrDefault(c => c.R�f�rence == R�f�rence);

            if (a is null) return NotFound();

            _cashcashContext.type_mat�riel?.Remove(a);
            _cashcashContext.SaveChanges();

            return Ok(a);
        }
    }
}