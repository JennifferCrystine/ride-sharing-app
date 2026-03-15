using Ride.Application.Calculators;
using Ride.Application.Strategies.Interfaces;
using Ride.Domain.Entities;

namespace Ride.Application.Strategies
{
    public class RadiusBasedMatchingStrategy : IRideMatchingStrategy
    {
        //get previous from cache at somepoint
        public double BaseRadiusInKm { get; private set; } = 5.0;       

        public IReadOnlyCollection<Driver> FindCandidateDrivers(Location passengerLocation, IList<Driver> drivers)
        {
            var closestDriversWithinBaseRadius = new List<Driver>();
            
            foreach (var driver in drivers)
            {
                double distance = DistanceCalculator.CalculateDistanceKm(
                    passengerLocation,
                    driver.CurrentLocation);

                if (distance <= BaseRadiusInKm)
                {
                    closestDriversWithinBaseRadius.Add(driver);
                }
            }
            return [.. closestDriversWithinBaseRadius.OrderBy(x => x.CurrentLocation)];
        }
    }
}
