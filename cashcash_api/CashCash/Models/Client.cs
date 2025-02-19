using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
/*using CashCash.Validations;
*/
namespace CashCash.Models
{
    public class Client
    {
        [Key]
        public int? NumClient { get; set; }
        public string? Raison_sociale { get; set; }
        public string? NumSiren { get; set; }
        public string? CodeApe { get; set; }
        public string? Adresse { get; set; }
        public string? NumTel { get; set; }
        public string? Mail { get; set; }
        public int? TempsDeplacement { get; set; }
        public double? Distance { get; set; }
        public int? NumAgence { get; set; }
    }
}