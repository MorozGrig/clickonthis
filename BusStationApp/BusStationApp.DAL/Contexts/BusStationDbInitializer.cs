using System;
using System.Data.Entity;
using BusStationApp.DAL.Entities;

namespace BusStationApp.DAL.Contexts
{
    public class BusStationDbInitializer : CreateDatabaseIfNotExists<BusStationDbContext>
    {
        protected override void Seed(BusStationDbContext context)
        {
            context.Roles.Add(new Role { Id = 1, Name = "Guest" });
            context.Roles.Add(new Role { Id = 2, Name = "User" });
            context.Roles.Add(new Role { Id = 3, Name = "Manager" });
            context.Roles.Add(new Role { Id = 4, Name = "Admin" });

            context.BusTrips.Add(new BusTrip
            {
                DepartureCity = "Москва",
                ArrivalCity = "Тула",
                DepartureTime = DateTime.Today.AddHours(10),
                ArrivalTime = DateTime.Today.AddHours(13),
                Price = 1200,
                BusNumber = "A101"
            });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
