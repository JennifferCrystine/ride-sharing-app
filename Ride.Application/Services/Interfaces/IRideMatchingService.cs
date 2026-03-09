using Ride.Domain.Entities;

namespace Ride.Application.Services.Interfaces
{
    public interface IRideMatchingService
    {
        public Driver FindClosestAvailableDriver(Location passengerLocation);
    }
}
