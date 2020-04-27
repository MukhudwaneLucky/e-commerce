using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "First Name")]
        public string first_name { get; set; }
        [Display(Name = "Last Name")]
        public string last_name { get; set; }
        [Display(Name = "Street Name")]
        public string street_name { get; set; }
        [Display(Name = "Town")]
        public string town { get; set; }
        [Display(Name = "City")]
        public string city { get; set; }
        [Display(Name = "Zip/Area/Postal Code")]
        [DataType(DataType.PostalCode)]
        public int zip_code { get; set; }
        [Display(Name = "Province")]
        public string province { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string email { get; set; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string phone_number { get; set; }
        [Display(Name = "User Type")]
        public string user_type { get; set; }
    }
}
