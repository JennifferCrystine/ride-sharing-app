using Ride.Domain.Entities.Abstractions;

namespace Ride.Domain.Entities
{
    public class Car(string name, decimal baseFarePerKm) : Vehicle(name, baseFarePerKm)
    {
    }
}
