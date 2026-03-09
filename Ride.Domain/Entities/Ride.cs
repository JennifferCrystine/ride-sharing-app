using Ride.Domain.Enums;
using Ride.Domain.Interfaces;
using Ride.Domain.Strategies.Interfaces;

namespace Ride.Domain.Entities
{
    public class Ride
    {
        public IFareStrategy FareStrategy { get; set; }

        public IList<IRideObserver> Observers { get; set; }

        public Driver Driver { get; set; }

        public Passenger Passenger { get; set; }

        public Location Destination { get; set; }

        public Location PickUp { get; set; }

        public RideStatus Status { get; set; }


        public void UpdateStatus(RideStatus status)
        {
            Status = status;
            Observers
                .ToList()
                .ForEach(observer => observer.Notify(this));
        }

        public void Subscribe(IRideObserver observer)
        {
            Observers.Add(observer);
        }

        public void Unsubscribe(IRideObserver observer)
        {
            Observers.Remove(observer);
        }
    }
}
