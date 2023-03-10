using Microsoft.EntityFrameworkCore;

namespace CarTrader.Services.Cars.Infrastructure.Extensions.EfCore
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}