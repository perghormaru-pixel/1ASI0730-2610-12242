namespace oop_sample.Procurement.Domain.Model.ValueObjects;

/// <summary>
/// Represents a product identifier in the proccurement bounded context. This
/// </summary>

public record ProductId
{
    public Guid Id { get; init; }
    
    /// <summary>
    /// Creates a new instance of <see cref="ProductId"/>
    /// </summary>
    /// <param name="id">The unique identifier for the product. Must not be an empty GUID</param>
    /// <exception cref="ArgumentException">Trhown when the provided id is empty GUID</exception>
    
    public ProductId(Guid id)
    {
        if (id == Guid.Empty)
            throw new ArgumentException($"{nameof(id)} cannot be an empty guid");
        Id = id;
    }
    
    /// <summary>
    /// Creates a new instance of <see cref="ProductId"/>
    /// </summary>
    /// <param name="id">The unique identifier </param>
    /// <returns></returns>
    public static ProductId New() => new(Guid.NewGuid());
    
    public override string ToString() => Id.ToString();
    
}