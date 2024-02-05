using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
/*using CashCash.Validations;
*/
namespace CashCash.Models
{
    public class Technicien
    {
        [Key]
        public int TechId { get; set; }
        public int AgenceId { get; set; }
        public string? Qualification { get; set; }
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
    }
}