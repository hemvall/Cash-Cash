using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
/*using CashCash.Validations;
*/
namespace CashCash.Models
{
    public class Controler
    {
        [Key]
        public int NumSerie { get; set; }
        public int NumIntervention { get; set; }
        public int TempsPasse { get; set; }
        public string? Commentaire { get; set; }
    }
}