using ParksLocator.Clients.Models;
using ParksLocator.Repositories.Models;
using ParksLocator.Services.Models;
using System.Collections.Generic;

namespace ParksLocator.Services.Interfaces
{
    public interface IDistanceService
    {
        IEnumerable<ParkDistance> GetParksDistance(IEnumerable<ParkCoordinates> parksCoordinates, ZipCoordinates visitorCoordinates);
    }
}
