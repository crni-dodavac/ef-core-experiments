namespace Entitties.Domain.UserContext;

public class UserId
{
    private readonly string _value;

    public UserId() : this(Guid.NewGuid().ToString("N"))
    {
    }
    
    public UserId(string value)
    {
        ArgumentException.ThrowIfNullOrEmpty(value);
        _value = value;
    }
    
    public override string ToString() => _value;
    
    public static implicit operator string(UserId userId) => userId.ToString();
}