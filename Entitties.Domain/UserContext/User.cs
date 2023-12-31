namespace Entitties.Domain.UserContext;

public class User : Entity<UserId>
{
    public User(UserId id) : base(id)
    {
    }
}