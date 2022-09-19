using Persistence.Models;

public interface IDbContextFactory
{
    WeatherDbContext DbContext { get; }
}