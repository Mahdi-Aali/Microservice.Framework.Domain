namespace Microservice.Framework.Domain.SeedWorker;

public class Entity<TKey>
{
    public TKey Id { get; set; } = default!;

    public Entity()
    {
        
    }

    public Entity(TKey id) => Id = id;
}