using Persistence.Models;

public interface ICityRepository : IRepository<City>
{
    Task<City> GetLastAccessedCityAsync();
    Task InsertOrUpdateCityAsync(City city);
}