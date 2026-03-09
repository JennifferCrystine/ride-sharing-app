namespace Ride.Domain.Entities.Abstractions
{
    public abstract class Vehicle(string name, decimal baseFarePerKm)
    {
        public string Name { get; protected set; } = name;

        public decimal BaseFarePerKm { get; protected set; } = baseFarePerKm;
    }
}
