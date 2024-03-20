using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
/*using CashCash.Validations;
*/
namespace CashCash.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        /*        public int? RoleId { get; set; }*/
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Mail { get; set; }
        public string? UserType { get; set; }
        public string? Password { get; set; }
    }
}