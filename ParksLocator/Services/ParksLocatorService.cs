using ParksLocator.Clients.Interfaces;
using ParksLocator.Clients.Models;
using ParksLocator.Repositories.Interfaces;
using ParksLocator.Services.Interfaces;
using ParksLocator.Services.Models;
using ParksLocator.Services.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ParksLocator.Services
{
    public class ParksLocatorService : IParksLocatorService
    {
        private readonly IParksLocatorRepository _parksLocatorRepository;
        private readonly IGoogleApiClient _googleApiClient;
        private readonly IDistanceService _distanceService;       

        public ParksLocatorService(IParksLocatorRepository parksLocatorRepository,
            IGoogleApiClient googleApiClient,
            IDistanceService distanceService)
           
        {
            _googleApiClient = googleApiClient;
            _parksLocatorRepository = parksLocatorRepository;
            _distanceService = distanceService;           
        }

        public async Task<IEnumerable<ParkDistance>> GetNearestParksAsync(ParksServiceRequest request)
        {
            ValidateRequest(request);
            var visitorCoordinates = await _googleApiClient.GetZipCoordinates(request.ZipCode);
            var parkDiststances = await GetParkDistancesAsync(request.Total, visitorCoordinates);            
            request.Total = request.Total != 0 ? request.Total : parkDiststances.Count();
            parkDiststances = parkDiststances.AsQueryable().OrderBy(a => a.Distance).Take(request.Total);
            return parkDiststances;
        }

        private void ValidateRequest(ParksServiceRequest request)
        {
            if (request.Total < 0)
                throw new ArgumentOutOfRangeException("A minimum of 1 park to find is required");
            if (request.ZipCode.Length != 5)
                throw new ArgumentException("Invalid Zip Code");
        }

        private async Task<IEnumerable<ParkDistance>> GetParkDistancesAsync(int? total, ZipCoordinates visitorCoordinates)
        {
            var parksCoordinates = await _parksLocatorRepository.GetAll();
            var parksDistances = _distanceService.GetParksDistance(parksCoordinates, visitorCoordinates);
            return parksDistances;
        }       
    }
}
