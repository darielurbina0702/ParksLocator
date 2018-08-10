using ParksLocator.Repositories.Models;

namespace ParksLocator.Services.Models
{
    public class ParkDistance
    {
        public double Distance { get; set; }
        public ParkCoordinates Park { get; set; }
    }
}
