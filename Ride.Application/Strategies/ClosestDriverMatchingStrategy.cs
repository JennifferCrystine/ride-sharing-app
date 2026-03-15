using Ride.Application.Calculators;
using Ride.Application.Strategies.Interfaces;
using Ride.Domain.Entities;

namespace Ride.Application.Strategies
{
    public class ClosestDriverMatchingStrategy : IRideMatchingStrategy
    {
        public IReadOnlyCollection<Driver> FindCandidateDrivers(Location passengerLocation, IList<Driver> drivers)
        {
            Driver closestDriver = null;
            double closestDistance = int.MaxValue;
            foreach (var driver in drivers)
            {
                double distance = DistanceCalculator.CalculateDistanceKm(
                    passengerLocation, driver.CurrentLocation);

                if (closestDistance > distance) 
                { 
                    closestDistance = distance;
                    closestDriver = driver;
                } 
            }

            return [closestDriver];
        }
    }
}
