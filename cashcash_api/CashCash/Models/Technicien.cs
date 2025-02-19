using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
/*using CashCash.Validations;
*/
namespace CashCash.Models
{
    public class Technicien
    {
        [Key]
        public int NumEmploye { get; set; }
        public string? NumTel { get; set; }
        public string? Qualification { get; set; }
        public DateTime? DateObtention { get; set; }
        public int NumAgence { get; set; }
    }
}