using System.Data.Entity;
using BusStationApp.DAL.Entities;

namespace BusStationApp.DAL.Contexts
{
    public class BusStationDbContext : DbContext
    {
        public BusStationDbContext() : base("name=BusStationDb")
        {
            Database.SetInitializer(new BusStationDbInitializer());
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<BusRoute> BusRoutes { get; set; }
        public DbSet<BusTrip> BusTrips { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.Phone).IsUnique();

            modelBuilder.Entity<OrderItem>()
                .HasRequired(x => x.Product)
                .WithMany(x => x.OrderItems)
                .HasForeignKey(x => x.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CartItem>()
                .HasRequired(x => x.User)
                .WithMany(x => x.CartItems)
                .HasForeignKey(x => x.UserId)
                .WillCascadeOnDelete(true);

            base.OnModelCreating(modelBuilder);
        }
    }
}
