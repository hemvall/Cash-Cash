using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
/*using CashCash.Validations;
*/
namespace CashCash.Models
{
	public class Employe
	{
		[Key]
		public int? NumEmploye { get; set; }
		public string? Nom { get; set; }
		public string? Prenom { get; set; }
		public string? Adresse { get; set; }
		public DateTime? DateEmbauche { get; set; }
	}
}