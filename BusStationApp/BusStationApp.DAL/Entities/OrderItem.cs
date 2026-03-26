namespace BusStationApp.DAL.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int BusTripId { get; set; }
        public decimal Price { get; set; }

        public virtual Order Order { get; set; }
        public virtual BusTrip BusTrip { get; set; }
    }
}
