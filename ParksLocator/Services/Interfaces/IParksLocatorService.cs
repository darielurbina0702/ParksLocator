using ParksLocator.Services.Models;
using ParksLocator.Services.Models.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParksLocator.Services.Interfaces
{
    public interface IParksLocatorService
    {
        Task<IEnumerable<ParkDistance>> GetNearestParksAsync(ParksServiceRequest request);
    }
}
