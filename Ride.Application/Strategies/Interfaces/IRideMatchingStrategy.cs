using Ride.Domain.Entities;

namespace Ride.Application.Strategies.Interfaces
{
    public interface IRideMatchingStrategy
    {
        public IReadOnlyCollection<Driver> FindCandidateDrivers(Location passengerLocation, IList<Driver> drivers);
    }
}
