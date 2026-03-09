using Ride.Domain.Entities.Abstractions;

namespace Ride.Domain.Entities
{
    public class Driver : User
    {
        public bool IsAvailable { get; private set; }

        public required Vehicle Vehicle { get; set; }

        public override string Notify(Ride ride)
        {
            if (ride.Driver.Equals(this))
            {
                return @$"
                    Passenger {ride.Passenger.Name},
                    Ride Status: {ride.Status}
                ";
            }
            return string.Empty;
        }

        public void UpdateAvailability(bool isAvailable)
        {
            IsAvailable = isAvailable;
        }
    }
}
