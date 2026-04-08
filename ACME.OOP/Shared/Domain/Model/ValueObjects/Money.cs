namespace oop_sample.Shared.Domain.Model.ValueObjects;

/// <summary>
/// Represents a monetary value with an amount and a currency code. This value object is immutable and provides basic operations for adding two money values together, as long as they have the same currency. The currency code must be a 3-letter ISO 4217 code. The amount is represented as a decimal to allow for precise financial calculations.
/// This is a value 
/// </summary>

public record Money
{
    public decimal Amount { get; init; }
    public string Currency { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="amount"></param>
    /// <param name="currency"></param>
    /// <exception cref="ArgumentException">Thrown when the currency is not a value 3-letter</exception>
    
    public Money(decimal amount, string currency)
    {
        if (string.IsNullOrWhiteSpace(currency) || currency.Length != 3)
            throw new ArgumentException($"Currency must be a 3-letter code: {currency}");
        Amount = amount;
        Currency = currency;
    }
    
    /// <summary>
    /// Returns a string representation of the money, combining the amount and currency
    /// </summary>
    /// <returns></returns>
    
    public override string ToString() => $"{Amount} {Currency}";
    
    /// <summary>
    /// Adds two <see cref="Money"/> objects
    /// </summary>
    /// <param name="other">The other <see cref="Money"/> to add. Must have the same currency</param>
    /// <returns>A new <see cref="Money"/> instance with the combined amount if the currencies match, throws an exception.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the currencies do not match</exception>

    public Money Add(Money? other)
    {
        return other == null ? this : new Money(Amount + other.Amount, Currency);
    }
    
    /// <summary>
    /// Multiplies the monetary value by a factor
    /// </summary>
    /// <param name="multiplier">The factor to multiply the amount by</param>
    /// <returns>A new <see cref="Money"/> instance with multiplied amount</returns>

    public Money Multiply(int multiplier) => new Money(Amount * multiplier, Currency);
}