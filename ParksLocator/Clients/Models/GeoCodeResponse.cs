﻿namespace ParksLocator.Clients.Models
{
    public class GeoCodeResponse
    {
        public string City { get; set; }
        public string State { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string ZipCode { get; set; }
        public string County { get; set; }
    }
}
