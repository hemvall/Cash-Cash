using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace CashCash.Models
{
    public class Contrat
    {
        [Key]
        public int NumContrat { get; set; }
        public int? ClientId { get; set; }
        public DateTime DateSignature { get; set; }
        public DateTime Dateecheance{ get; set; }
        public DateTime DateRenouvellement{ get; set; }
    }
}