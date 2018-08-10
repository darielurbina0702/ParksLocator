using GeoCoordinatePortable;
using ParksLocator.Clients.Models;
using ParksLocator.Repositories.Models;
using ParksLocator.Services.Interfaces;
using ParksLocator.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ParksLocator.Services
{
    public class DistanceService : IDistanceService
    {

        public IEnumerable<ParkDistance> GetParksDistance(IEnumerable<ParkCoordinates> parksCoordinates, ZipCoordinates visitorCoordinates)
        {
            return parksCoordinates.Select(p => GetParkDistance(p, visitorCoordinates));
        }

        private ParkDistance GetParkDistance(ParkCoordinates park, ZipCoordinates visitor)
        {
            var dealerCoordinates = new GeoCoordinate((double)park.Latitude, (double)park.Longitude);
            var customerCoordinates = new GeoCoordinate((double)visitor.Latitude, (double)visitor.Longitude);

            var distance = dealerCoordinates.GetDistanceTo(customerCoordinates);

            distance = Math.Round(distance, 2) / 1000;

            return new ParkDistance
            {
                Park = park,
                Distance = distance
            };
        }
    }
}
