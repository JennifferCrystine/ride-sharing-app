using Ride.Application.Services.Interfaces;
using Ride.Domain.Entities;
using Ride.Domain.Strategies.Interfaces;

namespace Ride.Application.Services
{
    public class RideService : IRideService
    {
        public Domain.Entities.Ride RequestRide(Location pickUp, Location destination, Passenger passenger, IFareStrategy fareStrategy)
        {
            throw new NotImplementedException();
        }
    }
}
