using Persistence.Models;

public interface ICityService
{
    Task<City> GetLastAccessedCityAsync();
    Task UpdateLastAccessedCityAsync(City city);
}