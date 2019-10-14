using System;
using System.Collections.Generic;
using System.Linq;
using Trips.Data;
using Trips.DTO.DAL;
using Trips.DTO.Repository;

namespace Trips.DTO
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ApplicationDbContext _context;

        public CountryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Country> GetCountries()
        {
            return _context.Countries.ToList();
        }

        public bool Disposed { get; private set; }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.Disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.Disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
