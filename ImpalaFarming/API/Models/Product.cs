using System.ComponentModel.DataAnnotations;


namespace API.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Product Name")]
        public string name { get; set; }
        [Display(Name = "Available In Stock")]
        public int available_in_stock { get; set; }
        [Display(Name = "Price")]
        public double price { get; set; }
        public string image_url { get; set; }

    }
}
