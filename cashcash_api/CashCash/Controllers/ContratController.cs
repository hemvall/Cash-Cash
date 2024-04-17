using cashcash_api.Context;
using CashCash.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Item.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContratController : ControllerBase
    {
        private readonly CashCashContext _cashcashContext;

        public ContratController(CashCashContext cashcashContext)
        {
            _cashcashContext = cashcashContext;
        }

        [HttpGet("{NumContrat:int}", Name = "GetContrats")]
        public ActionResult<Contrat> Get(int NumContrat)
        {
            var a = _cashcashContext.contrat_de_maintenance?.AsNoTracking().FirstOrDefault(x => x.NumContrat == NumContrat);
            return a is null ? NotFound() : a;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Contrat>> Get()
        {
            var exs = _cashcashContext.contrat_de_maintenance?.AsNoTracking().ToList();
            return exs is null ? NotFound() : exs;
        }

        [HttpPost]
        public ActionResult<Contrat> Post(Contrat ex)
        {
            if (ex is null) return BadRequest();

            _cashcashContext.contrat_de_maintenance?.Add(ex);
            _cashcashContext.SaveChanges();

            return new CreatedAtRouteResult("GetContrat", new { NumContrat = ex.NumContrat, ex });
        }

        [HttpPut("{NumContrat:int}")]
        public ActionResult<Contrat> Put(int NumContrat, Contrat ex)
        {
            if (ex is null || ex.NumContrat != NumContrat) return BadRequest();

            _cashcashContext.Entry(ex).State = EntityState.Modified;
            _cashcashContext.SaveChanges();

            return Ok(ex);
        }

        [HttpDelete("{NumContrat:int}")]
        public IActionResult Delete(int NumContrat)
        {
            var a = _cashcashContext.contrat_de_maintenance?.FirstOrDefault(c => c.NumContrat == NumContrat);

            if (a is null) return NotFound();

            _cashcashContext.contrat_de_maintenance?.Remove(a);
            _cashcashContext.SaveChanges();

            return Ok(a);
        }
    }
}