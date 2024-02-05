using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
/*using CashCash.Validations;
*/
namespace CashCash.Models
{
    public class MaterielIntervention
    {
        [Key]
        public int InterventionId { get; set; }
        public int MaterielId { get; set; }
    }
}