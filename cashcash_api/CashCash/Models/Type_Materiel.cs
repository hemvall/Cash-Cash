using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
/*using CashCash.Validations;
*/
namespace CashCash.Models
{
    public class Type_Materiel
    {
        [Key]
        public int? Référence { get; set; }
        public string? Libellé { get; set; }
    }
}