using GoogleMaps.LocationServices;
using ParksLocator.Clients.Interfaces;
using ParksLocator.Clients.Models;

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

            return new ZipCoordinates
            {
                ZipCode = zipCode,
                Latitude = (decimal)address.Latitude,
                Longitude = (decimal)address.Longitude
            };           
        }       
    }
}
