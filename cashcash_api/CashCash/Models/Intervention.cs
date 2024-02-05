using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
/*using CashCash.Validations;
*/
namespace CashCash.Models
{
    public class Intervention
    {
        [Key]
        public int InterventionId { get; set; }
        public int ContratId { get; set; }
        public int TechId { get; set; }
        public DateTime DateIntervention { get; set; }
        public string? Commentaire { get; set; }
        public string? Etat { get; set; }
    }
}