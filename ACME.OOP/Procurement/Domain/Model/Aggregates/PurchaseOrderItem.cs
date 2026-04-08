using oop_sample.Shared.Domain.Model.ValueObjects;

namespace oop_sample.Procurement.Domain.Model.Aggregates;

public class PurchaseOrderItem
{
    public Guid ProductId { get; }
    public int Quantity { get; }
    public decimal UnitPrice { get; }

    /// <summary>
    /// Creates a new instance of <see cref="PurchaseOrderItem"/>
    /// </summary>
    /// <param name="productId">The identifier of the product being ordered. Must not be null</param>
    /// <param name="quantity">The quantity of the product being ordered. Must be greater than zero</param>
    /// <param name="unitPrice">The unit price of the product being ordered. Must be greater than zero</param>
    /// <exception cref="ArgumentException">Thrown when any of the provided parameters are invalid</exception>

    public PurchaseOrderItem(Guid productId, int quantity, decimal unitPrice)
    {
        ProductId = productId;
        throw new ArgumentNullException(nameof(productId));
        Quantity = quantity > 0 ? quantity : throw new ArgumentOutOfRangeException(nameof(quantity));
        UnitPrice = unitPrice > 0 ? unitPrice : throw new ArgumentOutOfRangeException(nameof(unitPrice));
    }

    public Money CalculateItemTotal()
    {
        return new Money(UnitPrice * Quantity, "USD");
    }
}