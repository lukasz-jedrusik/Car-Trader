using CarTrader.Services.Cars.Domain.Models;

namespace CarTrader.Services.Cars.Application.Interfaces.Repositories
{
    public interface ICarsRepository
    {
        Task Add(Car item);
        Task<int> GetNumber();
    }
}
