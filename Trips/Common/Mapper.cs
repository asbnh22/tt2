using System.Linq;
using Trips.DTO.DAL;
using Trips.Models;

namespace Trips.Common
{
    public class Mapper
    {
       /* public static User ToDomain(UserModel entity)
         {
             return new User
             {
                 Id = entity.Id,
                 FirstName = entity.FirstName,
                 LastName = entity.LastName,
                 BornDate = entity.BornDate,
                 Email = entity.Email,
                 CityId = entity.CityId
             };
         }

         public static UserModel ToView(User entity)
         {
             return new UserModel
             {
                 Id = entity.Id,
                 FirstName = entity.FirstName,
                 LastName = entity.LastName,
                 BornDate = entity.BornDate,
                 Email = entity.Email,
                 CityId = entity.CityId
             };
         }*/

         public static City ToDomain(CityModel entity)
         {
             return new City
             {
                 Id = entity.Id,
                 Name = entity.Name,
                 CountryId = entity.CountryId,
                 //Users = entity.Users.Select(ToDomain).ToList()
             };
         }

         public static CityModel ToView(City entity)
         {
             return new CityModel
             {
                 Id = entity.Id,
                 Name = entity.Name,
                 CountryId = entity.CountryId,
                 //Users = entity.Users.Select(ToView).ToList()
             };
         }

         public static Country ToDomain(CountryModel entity)
         {
             return new Country
             {
                 Id = entity.Id,
                 Name = entity.Name,
                 Cities = entity.Cities.Select(ToDomain).ToList()
             };
         }

         public static CountryModel ToView(Country entity)
         {
             return new CountryModel
             {
                 Id = entity.Id,
                 Name = entity.Name,
                 Cities = entity.Cities.Select(ToView).ToList()
             };
         }

    }
}
