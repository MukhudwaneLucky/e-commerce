using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ImpalaFarming.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "Date Created")]
        public DateTime date_created { get; set; }
        [Display(Name = "Total Price")]
        public double total_price { get; set; }
        [ForeignKey("ShoppingCart")]
        public int cart_id { get; set; }
        [Display(Name = "Discount")]
        public double discount { get; set; }
        [Display(Name = "Delivery Address")]
        public string delivery_address { get; set; }

        
    }
}
