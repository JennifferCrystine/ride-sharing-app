using Ride.Domain.Entities;
using Ride.Infrastucture.Repositories.Interfaces;

namespace Ride.Infrastucture.Repositories
{
    public class DriverRepository : IDriverRepository
    {
        public Task AddAsync(Driver entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Driver>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IList<Driver> GetAvailableDrivers()
        {
            throw new NotImplementedException();
        }

        public Task<Driver> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Driver entity)
        {
            throw new NotImplementedException();
        }
    }
}
