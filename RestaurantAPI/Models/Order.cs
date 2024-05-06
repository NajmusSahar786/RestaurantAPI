using System.ComponentModel.DataAnnotations;
using System;

namespace RestaurantAPI.Models
{
    public class Order
    {
        [Required]
        [Key]
        public int Order_ID { get; set; }           // Unique order identifier
        [Required]
        public int User_ID { get; set; }            // Unique user identifier
        [Required]
        public int Transaction_ID { get; set; }     // Unique transacition identifier
        public DateTime Date_Time { get; set; }      // Date and time of order
    }
}
