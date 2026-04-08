using oop_sample.SCM.Domain.Model.ValueObjects;
using oop_sample.Shared.Domain.Model.ValueObjects;

namespace oop_sample.SCM.Domain.Model.aggregates;
using oop_sample.Shared.Domain.Model.ValueObjects;

public class Supplier(string identifier, string name, Address address)
{
    public SupplierId Id { get; init; }
    public string Name { get; init; }
    public Address Address { get; init; }
}
