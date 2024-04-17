using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
/*using CashCash.Validations;
*/
namespace CashCash.Models
{
    public class Intervention
    {
        [Key]
        public int? NumIntervention { get; set; }
        public DateTime DateIntervention { get; set; }
        public int? NumEmploye { get; set; }
        public TimeOnly? HeureIntervention { get; set; }
        public int? NumClient { get; set; }
    }
}