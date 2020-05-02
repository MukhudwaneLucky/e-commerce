using System.ComponentModel.DataAnnotations;

namespace Website.Models
{
    public class UserModelView
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetName { get; set; }
        public string TownName { get; set; }
        public string CityName { get; set; }
        public int PostalCode { get; set; }
        public string Province { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string UserType { get; set; }
    }
}