using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImpalaFarming.Models
{
    public class Review
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("Product")]
        public int product_id { get; set; }
        [Display(Name ="Rating")]
        public int rating { get; set; }
    }
}
