using Ride.Domain.Entities.Abstractions;
using Ride.Domain.Strategies.Interfaces;

namespace Ride.Domain.Strategies
{
    public class SharedStrategy : IFareStrategy
    {
        private const decimal BaseFarePerKm = 1.5m;

        public decimal CalculateFare(decimal distance, Vehicle vehicle) => distance * BaseFarePerKm * vehicle.BaseFarePerKm;
    }
}
