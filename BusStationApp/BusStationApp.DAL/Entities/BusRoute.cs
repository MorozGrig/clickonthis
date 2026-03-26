using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusStationApp.DAL.Entities
{
    public class BusRoute
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string DepartureCity { get; set; }

        [Required, MaxLength(100)]
        public string ArrivalCity { get; set; }

        public virtual ICollection<BusTrip> Trips { get; set; } = new HashSet<BusTrip>();
    }
}
