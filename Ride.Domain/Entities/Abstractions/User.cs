using Ride.Domain.Interfaces;

namespace Ride.Domain.Entities.Abstractions
{
    public abstract class User : IRideObserver
    {
        public required string Name { get; set; }

        public required string Email { get; set; }

        public Address Address { get; set; }

        public Location CurrentLocation { get; set; }


        public abstract string Notify(Ride ride);
    }
}
