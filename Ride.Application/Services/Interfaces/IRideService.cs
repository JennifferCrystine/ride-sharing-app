using Ride.Domain.Entities;
using Ride.Domain.Strategies.Interfaces;

namespace Ride.Application.Services.Interfaces
{
    public interface IRideService
    {
        Domain.Entities.Ride RequestRide(Location pickUp, Location destination, Passenger passenger, IFareStrategy fareStrategy);
    }
}
