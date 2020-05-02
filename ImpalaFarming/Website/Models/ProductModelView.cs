using System.ComponentModel.DataAnnotations;

namespace Website.Models
{
    public class ProductModelView
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int AvailableInStock { get; set; }
        public string ImageUrl { get; set; }
    }
}