using System.ComponentModel.DataAnnotations;

namespace ImpalaFarming.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string street_name { get; set; }
        public string city { get; set; }
        [DataType(DataType.PostalCode)]
        public int zip_code { get; set; }
        public string province { get; set; }
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [DataType(DataType.Password)]
        public string password { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string phone_number { get; set; }
    }
}
