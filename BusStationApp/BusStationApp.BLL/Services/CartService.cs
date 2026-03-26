using System;
using System.Data.Entity;
using System.Linq;
using BusStationApp.DAL.Contexts;
using BusStationApp.DAL.Entities;

namespace BusStationApp.BLL.Services
{
    public class CartService
    {
        public void AddToCart(int userId, int productId, int quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Количество должно быть больше нуля.");
            }

            using (var context = new BusStationDbContext())
            {
                var existingItem = context.CartItems.FirstOrDefault(x => x.UserId == userId && x.ProductId == productId);
                if (existingItem == null)
                {
                    context.CartItems.Add(new CartItem { UserId = userId, ProductId = productId, Quantity = quantity });
                }
                else
                {
                    existingItem.Quantity += quantity;
                }

                context.SaveChanges();
            }
        }

        public decimal Checkout(int userId)
        {
            using (var context = new BusStationDbContext())
            {
                var items = context.CartItems.Include("Product").Where(x => x.UserId == userId).ToList();
                if (!items.Any())
                {
                    throw new InvalidOperationException("Корзина пуста.");
                }

                var order = new Order
                {
                    UserId = userId,
                    Date = DateTime.Now,
                    TotalPrice = items.Sum(x => x.Product.Price * x.Quantity)
                };

                context.Orders.Add(order);
                context.SaveChanges();

                foreach (var item in items)
                {
                    context.OrderItems.Add(new OrderItem
                    {
                        OrderId = order.Id,
                        ProductId = item.ProductId,
                        Quantity = item.Quantity,
                        Price = item.Product.Price
                    });
                    context.CartItems.Remove(item);
                }

                context.SaveChanges();
                return order.TotalPrice;
            }
        }
    }
}
