using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ImpalaFarming.Models
{
    public class OrderHistory
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("User")]
        public int user_id { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
