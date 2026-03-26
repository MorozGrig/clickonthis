using System.ComponentModel.DataAnnotations;

namespace BusStationApp.DAL.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public decimal Price { get; set; }
        public decimal? OldPrice { get; set; }
        public decimal Discount { get; set; }

        [MaxLength(255)]
        public string ImagePath { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
