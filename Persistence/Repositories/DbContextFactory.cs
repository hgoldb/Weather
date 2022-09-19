using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Persistence.Models;

public class DbContextFactory : IDbContextFactory, IDisposable
{
    /// <summary>
    /// Create Db context with connection string
    /// </summary>
    /// <param name="settings"></param>
    public DbContextFactory(IOptions<DbContextSettings> settings) 
    {
        var options = new DbContextOptionsBuilder<WeatherDbContext>().UseSqlServer
                      (settings.Value.DbConnectionString).Options;
        DbContext = new WeatherDbContext(options);
    }

    /// <summary>
    /// Call Dispose to release DbContext
    /// </summary>
    ~DbContextFactory()
    {
        Dispose();
    }

    public WeatherDbContext DbContext { get; private set; }

    WeatherDbContext IDbContextFactory.DbContext => throw new NotImplementedException();

    /// <summary>
    /// Release DB context
    /// </summary>
    public void Dispose()
    {
        DbContext?.Dispose();
    }
}