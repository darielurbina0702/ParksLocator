using ParksLocator.Repositories.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParksLocator.Repositories.Interfaces
{
    public interface IParksLocatorRepository
    {
        Task<IEnumerable<ParkCoordinates>> GetAll();
    }
}
