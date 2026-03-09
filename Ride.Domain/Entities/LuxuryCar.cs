using Ride.Domain.Entities.Abstractions;

namespace Ride.Domain.Entities
{
    public class LuxuryCar(string name, decimal baseFarePerKm) : Vehicle(name, baseFarePerKm)
    {
    }
}
