using ParksLocator.Repositories.Interfaces;
using ParksLocator.Repositories.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParksLocator.Repositories
{
    public class ParksLocatorRepository : IParksLocatorRepository
    {
        private List<ParkCoordinates> parkList;

        public ParksLocatorRepository()
        {
            parkList = new List<ParkCoordinates>();

            parkList.Add(new ParkCoordinates() { ParkID = 1, ParkName = "St.Matthews Community Park", Address = "10 Pin Lane, St Matthews, KY 40207", Latitude = 38.2503952m, Longitude = -85.6425159m });
            parkList.Add(new ParkCoordinates() { ParkID = 2, ParkName = "Seneca Park", Address = "3151 Pee Wee Reese Rd, Louisville, KY 40207", Latitude = 38.2503952m, Longitude = -85.6425159m });
            parkList.Add(new ParkCoordinates() { ParkID = 3, ParkName = "Tom Sawyer State Park", Address = "3000 Freys Hill Rd, Louisville, KY 40241", Latitude = 38.2895624m, Longitude = -85.6603672m });
            parkList.Add(new ParkCoordinates() { ParkID = 4, ParkName = "Iroquois Park", Address = "1080 Amphitheater Rd, Louisville, KY 40214", Latitude = 38.1599439m, Longitude = -85.7783934m });
            parkList.Add(new ParkCoordinates() { ParkID = 5, ParkName = "Waverly Park", Address = "4800 Waverly Park Rd, Louisville, KY 40214", Latitude = 38.1975341m, Longitude = -85.7458374m });
            parkList.Add(new ParkCoordinates() { ParkID = 6, ParkName = "Shively Park", Address = "1902 Park Rd, Shively, KY 40216", Latitude = 38.1975341m, Longitude = -85.7458374m });
            parkList.Add(new ParkCoordinates() { ParkID = 7, ParkName = "Waterfront Park", Address = "401 River Rd, Louisville, KY 40202", Latitude = 38.2597829m, Longitude = -85.7460685m });
            parkList.Add(new ParkCoordinates() { ParkID = 8, ParkName = "Cherokee Park", Address = "745 Cochran Hill Rd, Louisville, KY 40206", Latitude = 38.2323308m, Longitude = -85.7206709m });
            parkList.Add(new ParkCoordinates() { ParkID = 9, ParkName = "Central Park", Address = "1340 S 4th St, Louisville, KY 40208", Latitude = 38.2296108m, Longitude = -85.7648158m });
            parkList.Add(new ParkCoordinates() { ParkID = 10, ParkName = "Sun Valley Park", Address = "6616 Ashby Ln, Louisville, KY 40272", Latitude = 38.1081039m, Longitude = -85.8898148m });
        }

        //not usinc Async because data is hard coded.
        public async Task<IEnumerable<ParkCoordinates>> GetAll()
        {
            return parkList;
        }
    }
}
