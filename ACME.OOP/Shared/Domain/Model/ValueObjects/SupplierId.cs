namespace oop_sample.Shared.Domain.Model.ValueObjects;

/// <summary>
/// Represents a supplier identifier value object in the Supply Chain Management (SCM) bounded context
/// </summary>

public record SupplierId
{
    public string Identifier { get; init; }
    
    /// <summary>
    /// Create a new instance of <see cref="SupplierId"/>
    /// </summary>
    /// <param name="identifier">The unique identifier for the supplier. It should not be null, empty or whitespace</param>
    /// <exception cref="ArgumentException">Thrown when the provided idetifier is null, empty, or consists only of whitespace</exception>
    
    public SupplierId(string identifier)
    {
        if(string.IsNullOrWhiteSpace(identifier))
            throw new ArgumentException("Supplier Identifier cannot be null or empty", nameof(identifier));
        Identifier = identifier;
    }
}