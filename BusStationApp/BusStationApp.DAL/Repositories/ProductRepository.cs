using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BusStationApp.DAL.Contexts;
using BusStationApp.DAL.Entities;

namespace BusStationApp.DAL.Repositories
{
    public class ProductRepository
    {
        private readonly BusStationDbContext _context;

        public ProductRepository(BusStationDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            return _context.Products.Include(x => x.Category).ToList();
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public bool Delete(int productId)
        {
            var hasOrders = _context.OrderItems.Any(x => x.ProductId == productId);
            if (hasOrders)
            {
                return false;
            }

            var product = _context.Products.Find(productId);
            if (product == null)
            {
                return true;
            }

            _context.Products.Remove(product);
            _context.SaveChanges();
            return true;
        }
    }
}
