namespace ParksLocator.Repositories.Models
{
    public class ParkCoordinates
    {       
        public int ParkID { get; set; }
        public string ParkName { get; set; }
        public string Address { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
