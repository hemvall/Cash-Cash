using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
/*using CashCash.Validations;
*/
namespace CashCash.Models
{
    public class ContratMateriel
    {
        [Key]
        public int MaterielId { get; set; }
        public int ContratId { get; set; }
    }
}