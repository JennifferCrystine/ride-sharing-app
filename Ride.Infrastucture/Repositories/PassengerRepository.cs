using Ride.Domain.Entities;
using Ride.Infrastucture.Repositories.Interfaces;

namespace Ride.Infrastucture.Repositories
{
    public class PassengerRepository : IPassengerRepository
    {
        public Task AddAsync(Passenger entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Passenger>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Passenger> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Passenger entity)
        {
            throw new NotImplementedException();
        }
    }
}
