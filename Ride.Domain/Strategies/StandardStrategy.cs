using Ride.Domain.Entities.Abstractions;
using Ride.Domain.Strategies.Interfaces;

namespace Ride.Domain.Strategies
{
    public class StandardStrategy : IFareStrategy
    {
        private const decimal BaseFarePerKm = 1.8m;

        public decimal CalculateFare(decimal distance, Vehicle vehicle) => distance * BaseFarePerKm * vehicle.BaseFarePerKm;
    }
}
