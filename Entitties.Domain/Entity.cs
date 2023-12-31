namespace Entitties.Domain;

public abstract class Entity<TId>
{
    public TId Id { get; }

    public Entity(TId id)
    {
        Id = id;
    }
}