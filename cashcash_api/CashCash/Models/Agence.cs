using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
/*using CashCash.Validations;
*/
namespace CashCash.Models
{
    public class Agence
    {
        [Key]
        public int NumAgence { get; set; }
        public string? NomAgence { get; set; }
        public string? Adresse { get; set; }
        public string? NumTel { get; set; }
    }
}