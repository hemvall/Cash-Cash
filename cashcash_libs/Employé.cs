using System;
/*using CashCash.Validations;
*/
namespace CashCash.Models
{
	public class Employe
	{
		
		public int NumEmploye { get; set; }
		public string Nom { get; set; }
		public string Prenom { get; set; }
		public string Adresse { get; set; }
		public DateTime DateEmbauche { get; set; }
	}
}