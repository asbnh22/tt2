using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Trips.DTO.DAL;

namespace Trips.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public new DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Models.CityModel> CityModel { get; set; }
        public DbSet<Models.CountryModel> CountryModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne<City>(c => c.City)
                .WithMany(u => u.Users)
                .HasForeignKey(u => u.CityId);

            modelBuilder.Entity<City>()
                .HasOne<Country>(c => c.Country)
                .WithMany(c => c.Cities)
                .HasForeignKey(c => c.CountryId);

            ///////////////////////////////////////////////
            //modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<City>().ToTable("Cities");
            modelBuilder.Entity<Country>().ToTable("Countries");

            modelBuilder.Entity<Country>().HasData(
                new Country[]
                {
                    new Country{Id = 1, Name = "Russia"},
                });

            modelBuilder.Entity<City>().HasData(
                new City[]
                {
                    new City {Id = 1, Name = "Voronezh", CountryId = 1},
                    new City {Id = 2, Name = "Moscow", CountryId = 1},
                    new City {Id = 3, Name = "Saint Petersburg", CountryId = 1}
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}

