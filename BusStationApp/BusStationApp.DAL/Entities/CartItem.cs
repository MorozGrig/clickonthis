namespace BusStationApp.DAL.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BusTripId { get; set; }

        public virtual User User { get; set; }
        public virtual BusTrip BusTrip { get; set; }
    }
}
