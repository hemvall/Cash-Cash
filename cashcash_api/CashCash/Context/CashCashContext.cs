using CashCash.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace cashcash_api.Context
{
    public class CashCashContext : DbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<Agence>? Agence { get; set; }
        public DbSet<Client>? Client { get; set; }
        public DbSet<Contrat>? Contrat { get; set; }
        public DbSet<ContratMateriel>? ContratMateriel { get; set; }
        public DbSet<Intervention>? Intervention { get; set; }
        public DbSet<Materiel>? Materiel { get; set; }
        public DbSet<MaterielIntervention>? MaterielIntervention { get; set; }
        public DbSet<Technicien>? Technicien { get; set; }

        public CashCashContext(DbContextOptions<CashCashContext> options) : base(options)
        {
        }
    }
}