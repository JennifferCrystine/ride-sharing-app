using Ride.Application.Services.Interfaces;
using Ride.Application.Strategies.Interfaces;
using Ride.Domain.Entities;

namespace Ride.Application.Services
{
    public class RideMatchingService : IRideMatchingService
    {
        public Driver FindClosestAvailableDriver(Location passengerLocation, IRideMatchingStrategy matchingStrategy)
        {
            throw new NotImplementedException();
        }
    }
}