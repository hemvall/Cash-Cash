using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
/*using CashCash.Validations;
*/
namespace CashCash.Models
{
    public class Materiel
    {
        [Key]
        public int? NumSerie { get; set; }
        public DateTime? DateVente { get; set; }
        public DateTime? DateInstallation { get; set; }
        public float? PrixVente { get; set; }
        public string? Emplacement { get; set; }
        public int? Référence { get; set; }
        public int? NumContrat { get; set; }
        public int? NumClient { get; set; }
    }
}