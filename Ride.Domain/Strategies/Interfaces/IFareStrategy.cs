using Ride.Domain.Entities.Abstractions;

namespace Ride.Domain.Strategies.Interfaces
{
    public interface IFareStrategy
    {
        public decimal CalculateFare(decimal distance, Vehicle vehicle);
    }
}
