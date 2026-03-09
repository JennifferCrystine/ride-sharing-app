using Ride.Domain.Entities.Abstractions;

namespace Ride.Domain.Entities
{
    public class Passenger : User
    {
        public override string Notify(Ride ride)
        {
            if (ride.Passenger.Equals(this))
            {
                return @$"
                    Driver {ride.Driver.Name},
                    Ride Status: {ride.Status}
                ";
            }

            return string.Empty;
        }
    }
}
