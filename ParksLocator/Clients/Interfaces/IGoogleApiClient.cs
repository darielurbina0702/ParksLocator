using ParksLocator.Clients.Models;

namespace ParksLocator.Clients.Interfaces
{
    public interface IGoogleApiClient
    {
        ZipCoordinates GetZipCoordinates(string zipCode);
    }
}
