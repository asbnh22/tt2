using System.ComponentModel.DataAnnotations.Schema;

namespace Trips.Models
{
    public class CityModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        public CountryModel Country { get; set; }
    }
}
