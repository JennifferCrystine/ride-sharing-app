using Ride.Domain.Entities;

namespace Ride.Application.Calculators
{
    public static class DistanceCalculator
    {
        private const double EarthRadiusKm = 6371;

        public static double CalculateDistanceKm(Location a, Location b)
        {
            double lat1 = DegreesToRadians(a.Latitude);
            double lon1 = DegreesToRadians(a.Longitude);
            double lat2 = DegreesToRadians(b.Latitude);
            double lon2 = DegreesToRadians(b.Longitude);

            double dLat = lat2 - lat1;
            double dLon = lon2 - lon1;

            double h =
                Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Cos(lat1) * Math.Cos(lat2) *
                Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double distance = 2 * EarthRadiusKm * Math.Asin(Math.Sqrt(h));

            return distance;
        }

        private static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }
    }
}
