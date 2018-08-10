using GoogleMaps.LocationServices;
using ParksLocator.Clients.Interfaces;
using ParksLocator.Clients.Models;
using System;

namespace ParksLocator.Clients
{
    public class GoogleApiClient : IGoogleApiClient
    {       

        public GoogleApiClient() { }

        public ZipCoordinates GetZipCoordinates(string zipCode)
        {
            var coordinates =  GetZipCodeCoordinates(zipCode);
            return coordinates;
        }

        private ZipCoordinates GetZipCodeCoordinates(string zipCode)
        {
            var locationService = new GoogleLocationService();
            var address = locationService.GetLatLongFromAddress(zipCode);

            if (address == null)
                throw new InvalidOperationException("you have exceeded the maximum number of calls to the google api");

            return new ZipCoordinates
            {
                ZipCode = zipCode,
                Latitude = (decimal)address.Latitude,
                Longitude = (decimal)address.Longitude
            };           
        }       
    }
}
