using ParksLocator.Clients.Models;
using System.Threading.Tasks;

namespace ParksLocator.Clients.Interfaces
{
    public interface IGoogleApiClient
    {
        Task<ZipCoordinates> GetZipCoordinates(string zipCode);
    }
}
