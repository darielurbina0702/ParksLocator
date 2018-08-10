using ParksLocator.DAL.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace ParksLocator.DAL
{
    public class ParksLocatorInitializer : DropCreateDatabaseAlways<ParksLocatorContext>
    {
        protected override void Seed(ParksLocatorContext context)
        {
            IList<ParkCoordinates> parkList = new List<ParkCoordinates>();

            parkList.Add(new ParkCoordinates() { ParkName = "St.Matthews Community Park", Address = "10 Pin Lane, St Matthews, KY 40207", Latitude = 38.2503952m, Longitude = -85.6425159m });
            parkList.Add(new ParkCoordinates() { ParkName = "Seneca Park", Address = "3151 Pee Wee Reese Rd, Louisville, KY 40207", Latitude = 38.2503952m, Longitude = -85.6425159m });
            parkList.Add(new ParkCoordinates() { ParkName = "Tom Sawyer State Park", Address = "3000 Freys Hill Rd, Louisville, KY 40241", Latitude = 38.2895624m, Longitude = -85.6603672m });
            parkList.Add(new ParkCoordinates() { ParkName = "Iroquois Park", Address = "1080 Amphitheater Rd, Louisville, KY 40214", Latitude = 38.1599439m, Longitude = -85.7783934m });
            parkList.Add(new ParkCoordinates() { ParkName = "Waverly Park", Address = "4800 Waverly Park Rd, Louisville, KY 40214", Latitude = 38.1975341m, Longitude = -85.7458374m });
            parkList.Add(new ParkCoordinates() { ParkName = "Shively Park", Address = "1902 Park Rd, Shively, KY 40216", Latitude = 38.1975341m, Longitude = -85.7458374m });
            parkList.Add(new ParkCoordinates() { ParkName = "Waterfront Park", Address = "401 River Rd, Louisville, KY 40202", Latitude = 38.2597829m, Longitude = -85.7460685m });
            parkList.Add(new ParkCoordinates() { ParkName = "Cherokee Park", Address = "745 Cochran Hill Rd, Louisville, KY 40206", Latitude = 38.2323308m, Longitude = -85.7206709m });
            parkList.Add(new ParkCoordinates() { ParkName = "Central Park", Address = "1340 S 4th St, Louisville, KY 40208", Latitude = 38.2296108m, Longitude = -85.7648158m });
            parkList.Add(new ParkCoordinates() { ParkName = "Sun Valley Park", Address = "6616 Ashby Ln, Louisville, KY 40272", Latitude = 38.1081039m, Longitude = -85.8898148m });

            context.Parks.AddRange(parkList);
            base.Seed(context);
        }
    }
}
