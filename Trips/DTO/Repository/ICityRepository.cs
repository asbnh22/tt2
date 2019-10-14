using System;
using System.Collections.Generic;
using Trips.DTO.DAL;

namespace Trips.DTO.Repository
{
    public interface ICityRepository : IDisposable
    {
        List<City> GetCities();
    }
}
