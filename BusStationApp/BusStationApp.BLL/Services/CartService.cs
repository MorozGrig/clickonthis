using System;
using System.Data.Entity;
using System.Linq;
using BusStationApp.DAL.Contexts;
using BusStationApp.DAL.Entities;

namespace BusStationApp.BLL.Services
{
    public class CartService
    {
        public void AddTripToCart(int userId, int tripId)
        {
            if (userId <= 0)
            {
                throw new InvalidOperationException("Только авторизованный пользователь может добавлять билеты в корзину.");
            }

            using (var context = new BusStationDbContext())
            {
                var trip = context.BusTrips.Find(tripId);
                if (trip == null)
                {
                    throw new InvalidOperationException("Выбранный рейс не найден.");
                }

                var existingItem = context.CartItems.FirstOrDefault(x => x.UserId == userId && x.BusTripId == tripId);
                if (existingItem != null)
                {
                    throw new InvalidOperationException("Билет на этот рейс уже добавлен в корзину.");
                }

                context.CartItems.Add(new CartItem { UserId = userId, BusTripId = tripId });
                context.SaveChanges();
            }
        }

        public decimal Checkout(int userId)
        {
            if (userId <= 0)
            {
                throw new InvalidOperationException("Для оформления заказа необходимо войти в систему.");
            }

            using (var context = new BusStationDbContext())
            {
                var items = context.CartItems.Include(x => x.BusTrip).Where(x => x.UserId == userId).ToList();
                if (!items.Any())
                {
                    throw new InvalidOperationException("Корзина пуста. Добавьте билеты перед оформлением заказа.");
                }

                var order = new Order
                {
                    UserId = userId,
                    Date = DateTime.Now,
                    TotalPrice = items.Sum(x => x.BusTrip.Price)
                };

                context.Orders.Add(order);
                context.SaveChanges();

                foreach (var item in items)
                {
                    context.OrderItems.Add(new OrderItem
                    {
                        OrderId = order.Id,
                        BusTripId = item.BusTripId,
                        Price = item.BusTrip.Price
                    });

                    context.CartItems.Remove(item);
                }

                context.SaveChanges();
                return order.TotalPrice;
            }
        }
    }
}
