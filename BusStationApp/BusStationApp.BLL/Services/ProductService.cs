using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BusStationApp.DAL.Contexts;
using BusStationApp.DAL.Entities;
using BusStationApp.DAL.Repositories;

namespace BusStationApp.BLL.Services
{
    public class ProductService
    {
        public List<Product> GetCatalog(string search = null)
        {
            using (var context = new BusStationDbContext())
            {
                var query = context.Products.Include("Category").AsQueryable();

                if (!string.IsNullOrWhiteSpace(search))
                {
                    query = query.Where(x => x.Name.Contains(search));
                }

                return query.OrderBy(x => x.Name).ToList();
            }
        }

        public decimal CalculateTotalPrice(decimal price, decimal discount)
        {
            if (discount < 0 || discount > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(discount), "Скидка должна быть от 0 до 100.");
            }

            return price - (price * discount / 100m);
        }

        public bool DeleteProduct(int productId)
        {
            using (var context = new BusStationDbContext())
            {
                var repository = new ProductRepository(context);
                return repository.Delete(productId);
            }
        }
    }
}
