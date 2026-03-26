using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusStationApp.DAL.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Required, MaxLength(80)]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
