using BoatRentalSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentalSystem.Core.Interfaces;

public interface ICountryRepository
{
    Task<IEnumerable<Country>> GetAllCountries();
    Task<Country> GetCountryById(int id);
    Task AddCountry(Country country);
    Task UpdateCountry(Country country);
    Task DeleteCountry(int id);
}
