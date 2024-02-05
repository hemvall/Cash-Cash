using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
/*using CashCash.Validations;
*/
namespace CashCash.Models
{
    public class Agence
    {
        [Key]
        public int AgenceId { get; set; }
        public string? Nom { get; set; }
        public string? Adresse { get; set; }
        public string? NumTel { get; set; }
        public string? Mail { get; set; }
    }
}