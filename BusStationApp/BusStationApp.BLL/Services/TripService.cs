using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BusStationApp.DAL.Contexts;
using BusStationApp.DAL.Entities;

namespace BusStationApp.BLL.Services
{
    public class TripService
    {
        public List<BusTrip> GetTrips(string search = null)
        {
            using (var context = new BusStationDbContext())
            {
                var query = context.BusTrips.AsQueryable();

                if (!string.IsNullOrWhiteSpace(search))
                {
                    var term = search.Trim();
                    query = query.Where(x => x.DepartureCity.Contains(term) || x.ArrivalCity.Contains(term));
                }

                return query.OrderBy(x => x.DepartureTime).ToList();
            }
        }

        public string Validate(string departureCity, string arrivalCity, DateTime departureTime, DateTime arrivalTime, decimal price)
        {
            if (string.IsNullOrWhiteSpace(departureCity)) return "Введите город отправления.";
            if (string.IsNullOrWhiteSpace(arrivalCity)) return "Введите город прибытия.";
            if (departureCity.Trim().Equals(arrivalCity.Trim(), StringComparison.OrdinalIgnoreCase)) return "Город отправления и прибытия не должны совпадать.";
            if (arrivalTime <= departureTime) return "Время прибытия должно быть позже времени отправления.";
            if (price <= 0) return "Цена рейса должна быть больше нуля.";
            return null;
        }

        public void AddTrip(BusTrip trip)
        {
            using (var context = new BusStationDbContext())
            {
                context.BusTrips.Add(trip);
                context.SaveChanges();
            }
        }

        public void UpdateTrip(BusTrip trip)
        {
            using (var context = new BusStationDbContext())
            {
                context.Entry(trip).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public bool DeleteTrip(int tripId)
        {
            using (var context = new BusStationDbContext())
            {
                var trip = context.BusTrips.Find(tripId);
                if (trip == null)
                {
                    return false;
                }

                context.BusTrips.Remove(trip);
                context.SaveChanges();
                return true;
            }
        }
    }
}
