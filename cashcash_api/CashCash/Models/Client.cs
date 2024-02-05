using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
/*using CashCash.Validations;
*/
namespace CashCash.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public int LanguageId { get; set; }
        public int? AgenceId { get; set; }
        public string? RaisonSocial { get; set; }
        public string? NumeroSiren { get; set; }
        public string? CodeApe { get; set; }
        public string? AdressePostal { get; set; }
        public string? NumeroTelphone { get; set; }
        public string? NumeroTelecopie { get; set; }
        public string? Email { get; set; }
        public double? DistanceAgence { get; set; }
        public double? DureeMoyDeplacement { get; set; }
    }
}