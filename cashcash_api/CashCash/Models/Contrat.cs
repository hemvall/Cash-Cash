using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace CashCash.Models
{
    public class Contrat
    {
        [Key]
        public int NumContrat { get; set; }
        public DateTime DateSignature { get; set; }
        public DateTime DateFin{ get; set; }
        public int? NumClient { get; set; }
    }
}