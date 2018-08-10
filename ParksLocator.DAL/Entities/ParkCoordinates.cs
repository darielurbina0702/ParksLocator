using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParksLocator.DAL.Entities
{
    public class ParkCoordinates
    {
        [Key]
        public int ParkID { get; set; }
        public string ParkName { get; set; }
        public string Address { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
