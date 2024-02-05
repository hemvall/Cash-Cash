using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
/*using CashCash.Validations;
*/
namespace CashCash.Models
{
    public class Materiel
    {
        [Key]
        public int NumSerie { get; set; }
        public int ClientId { get; set; }
        public string? TypeMateriel { get; set; }
        public string? Description { get; set; }
        public DateTime? DateVente { get; set; }
        public DateTime? DateInstall { get; set; }
        public int? PrixVente { get; set; }
    }
}