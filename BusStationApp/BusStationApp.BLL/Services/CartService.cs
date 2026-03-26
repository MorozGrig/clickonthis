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
            if (userId <= 0)
            {
                throw new InvalidOperationException("Только авторизованный пользователь может добавлять товары в корзину.");
            }

            if (quantity <= 0)
            {
                throw new ArgumentException("Количество должно быть больше нуля.");
            }

            using (var context = new BusStationDbContext())
            {
                var existingItem = context.CartItems.FirstOrDefault(x => x.UserId == userId && x.ProductId == productId);
                if (existingItem != null)
                {
                    throw new InvalidOperationException("Товар уже добавлен в корзину.");
                }

                context.CartItems.Add(new CartItem { UserId = userId, ProductId = productId, Quantity = quantity });
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
                var items = context.CartItems.Include("Product").Where(x => x.UserId == userId).ToList();
                if (!items.Any())
                {
                    throw new InvalidOperationException("Корзина пуста. Добавьте товары перед оформлением заказа.");
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
