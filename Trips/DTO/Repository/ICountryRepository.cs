using System;
using System.Collections.Generic;
using Trips.DTO.DAL;

namespace Trips.DTO.Repository
{
    public interface ICountryRepository : IDisposable
    {
        List<Country> GetCountries();
    }
}
