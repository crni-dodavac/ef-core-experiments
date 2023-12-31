using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Entitties.Database.DatabaseDefinitions;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<NetworkDbContext>
{
    public DesignTimeDbContextFactory()
    {
    }
    
    public NetworkDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .AddEnvironmentVariables()
            .AddJsonFile("migrations.json", true)
            .Build();
        
        var connectionString = configuration["NetworkDb:ConnectionString"];

        var dbContextOptions = new DbContextOptionsBuilder<NetworkDbContext>()
            .UseNpgsql(connectionString)
            .Options;

        return new NetworkDbContext(dbContextOptions);
    }
}