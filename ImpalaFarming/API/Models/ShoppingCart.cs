using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class ShoppingCart
    {
        [Key]
        public int CartID { get; set; }
        public List<Product> Products { get; set; }
        public double TotalPrice { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
    }
}
