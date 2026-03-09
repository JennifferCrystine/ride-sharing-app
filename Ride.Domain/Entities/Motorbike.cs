using Ride.Domain.Entities.Abstractions;

namespace Ride.Domain.Entities
{
    public class Motorbike(string name, decimal baseFarePerKm) : Vehicle(name, baseFarePerKm)
    {
    }
}
