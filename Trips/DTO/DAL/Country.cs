using System.Collections.Generic;

namespace Trips.DTO.DAL
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
