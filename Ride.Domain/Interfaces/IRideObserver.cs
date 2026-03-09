namespace Ride.Domain.Interfaces
{
    public interface IRideObserver
    {
        string Notify(Entities.Ride ride);
    }
}
