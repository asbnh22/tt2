using System;
using Microsoft.AspNetCore.Identity;

namespace Trips.DTO.DAL
{
    public class User : IdentityUser
    {
        public string UserLogin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BornDate { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }

    }
}
