using Ride.Domain.Entities;
using Ride.Infrastucture.Base;

namespace Ride.Infrastucture.Repositories.Interfaces
{
    public interface IDriverRepository : IRepository<Driver>
    {
        public IList<Driver> GetAvailableDrivers();
    }
}
