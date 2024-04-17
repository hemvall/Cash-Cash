using CashCash.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace cashcash_api.Context
{
    public class CashCashContext : DbContext
    {
        public DbSet<User>? User { get; set; }
        public DbSet<User>? assistant { get; set; }
        public DbSet<Agence>? agence { get; set; }
        public DbSet<Client>? client { get; set; }
        public DbSet<Contrat>? contrat_de_maintenance { get; set; }
        public DbSet<Controler>? controler { get; set; }
        public DbSet<Intervention>? intervention { get; set; }
        public DbSet<Materiel>? matériel { get; set; }
        public DbSet<Type_Materiel>? type_matériel { get; set; }
        public DbSet<Technicien>? technicien { get; set; }

        public CashCashContext(DbContextOptions<CashCashContext> options) : base(options)
        {
        }
    }
}