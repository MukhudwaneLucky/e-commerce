using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace API.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime DateCreated { get; set; }
        public double TotalPrice { get; set; }
        public string DeliveryETA { get; set; }
    }
}
