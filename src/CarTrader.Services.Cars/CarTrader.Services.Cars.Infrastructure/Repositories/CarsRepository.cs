using CarTrader.Services.Cars.Application.Interfaces.Repositories;
using CarTrader.Services.Cars.Domain.Models;
using CarTrader.Services.Cars.Infrastructure.Extensions.EfCore;
using Microsoft.EntityFrameworkCore;

namespace CarTrader.Services.Cars.Infrastructure.Repositories
{
    public class CarsRepository : ICarsRepository
    {
        private readonly DataContext _context;

        public CarsRepository(DataContext context)
        {
            _context = context;
        }

        public async Task Add(Car item)
        {
            _context.Cars.Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task<int> GetNumber()
        {
            int? dbval = await _context.Cars.Where(x => x.Year == DateTime.UtcNow.Year)
                .MaxAsync(y => (int?)y.Number);

            if (dbval == null) return 1;
            return ((int)dbval) + 1;
        }
    }
}
