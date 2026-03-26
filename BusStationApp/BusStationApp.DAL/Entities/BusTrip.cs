using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusStationApp.DAL.Entities
{
    public class BusTrip
    {
        public int Id { get; set; }

        [Required, MaxLength(80)]
        public string DepartureCity { get; set; }

        [Required, MaxLength(80)]
        public string ArrivalCity { get; set; }

        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }

        [Range(typeof(decimal), "0.01", "999999")]
        public decimal Price { get; set; }

        [MaxLength(50)]
        public string BusNumber { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
        public virtual ICollection<CartItem> CartItems { get; set; } = new HashSet<CartItem>();
    }
}
