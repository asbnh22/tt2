using System;
using System.Collections.Generic;
using System.Linq;
using Trips.Data;
using Trips.DTO.DAL;
using Trips.DTO.Repository;

namespace Trips.DTO
{
    public class CityRepository : ICityRepository
    {
        private readonly ApplicationDbContext _context;

        public CityRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<City> GetCities()
        {
            return _context.Cities.ToList();
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
