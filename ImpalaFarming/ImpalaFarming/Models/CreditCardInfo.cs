using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImpalaFarming.Models
{
    public class CreditCardInfo
    {
        [Key]
        [CreditCard]
        [Display(Name = "Credit Card Number")]
        public int number { get; set; }
        [Display(Name = "CVV Number")]
        public int cvv_number { get; set; }
        [Display(Name = "Credit Card Type")]
        public string type { get; set; }
        [Display(Name = "Expiry Date")]
        public string expiry_date { get; set; }
        [ForeignKey("User")]
        public int user_id { get; set; }
    }
}
