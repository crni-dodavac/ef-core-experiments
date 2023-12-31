using Entitties.Database.DatabaseDefinitions;

namespace Entitties.Database.Repositories;

public class UserRepository
{
    private readonly NetworkDbContext _context;

    public UserRepository(NetworkDbContext context)
    {
        _context = context;
    }
}