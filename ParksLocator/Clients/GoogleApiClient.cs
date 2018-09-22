using GoogleMaps.LocationServices;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using ParksLocator.Clients.Interfaces;
using ParksLocator.Clients.Models;
using ParksLocator.Options;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ParksLocator.Clients
{
    public class GoogleApiClient : IGoogleApiClient
    {       
        private readonly GoogleApiSettings _googleApiSettings;
        public GoogleApiClient(IOptions<GoogleApiSettings> googleApiSettings)
        {
            _googleApiSettings = googleApiSettings.Value;
        }

        public async Task<ZipCoordinates> GetZipCoordinates(string zipCode)
        {
            var coordinates = await GetZipCodeCoordinatesAsync(zipCode);
            return coordinates;
        }

        private async Task<ZipCoordinates> GetZipCodeCoordinatesAsync(string zipCode)
        {
            HttpClient _client = new HttpClient();
            var url = _googleApiSettings.GoogleApiUrl +
                      $"{zipCode}?key={_googleApiSettings.Key}";
            var locationResponse = await _client.GetAsync(url);
            var locationResult = await locationResponse.Content.ReadAsStringAsync();
            var coordinates = MapCoordinatesResult(locationResult, zipCode);
            return coordinates;
        }

        private ZipCoordinates MapCoordinatesResult(string locationResult, string zipCode)
        {
            var root = JsonConvert.DeserializeObject<GeoCodeResponse>(locationResult);
            var lat = Convert.ToDecimal(root.Latitude);
            var lng = Convert.ToDecimal(root.Longitude);

            return new ZipCoordinates
            {
                ZipCode = zipCode,
                Latitude = lat,
                Longitude = lng
            };
        }
    }
}
