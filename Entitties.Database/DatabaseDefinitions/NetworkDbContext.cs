using Entitties.Domain.UserContext;
using Microsoft.EntityFrameworkCore;

namespace Entitties.Database.DatabaseDefinitions;

public class NetworkDbContext : DbContext
{
    public DbSet<User> Users { get; set; } = default!;

    public NetworkDbContext(DbContextOptions<NetworkDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .DefineUserModel();
    }
}