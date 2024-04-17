using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
/*using CashCash.Validations;
*/
namespace CashCash.Models
{
    public class Assistant
    {
        [Key]
        public int? NumEmploye { get; set; }
    }
}