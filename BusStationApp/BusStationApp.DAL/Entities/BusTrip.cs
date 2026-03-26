using System;
using System.ComponentModel.DataAnnotations;

namespace BusStationApp.DAL.Entities
{
    public class BusTrip
    {
        public int Id { get; set; }
        public int RouteId { get; set; }

        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }

        [MaxLength(50)]
        public string BusNumber { get; set; }

        public virtual BusRoute Route { get; set; }
    }
}
