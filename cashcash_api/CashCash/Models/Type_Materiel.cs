using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
/*using CashCash.Validations;
*/
namespace CashCash.Models
{
    public class Type_Materiel
    {
        [Key]
        public int? R�f�rence { get; set; }
        public string? Libell� { get; set; }
    }
}