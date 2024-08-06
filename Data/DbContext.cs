using Microsoft.EntityFrameworkCore;
using RetroVideoStore.Models;

namespace RetroVideoStore.Data
{
    public class RentalContext : DbContext
    {
        public RentalContext(DbContextOptions<RentalContext> options) : base(options) { }

        public DbSet<Rental> Rentals { get; set; }
    }

    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options) {}

        public DbSet<Order> Orders { get; set; }
    }
}
