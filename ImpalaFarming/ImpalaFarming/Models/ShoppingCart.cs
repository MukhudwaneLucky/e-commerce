using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ImpalaFarming.Models
{
    public class ShoppingCart
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Total Price")]
        public double total_price { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "Date Created")]
        public DateTime date_created { get; set; }
        [ForeignKey("User")]
        public int user_id { get; set; }
        public ICollection<Product> Products { get; set; }
        
    }
}
