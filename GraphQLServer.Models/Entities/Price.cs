
namespace GraphQLServer.Model.Entities;
public record Price
{
    public double Amount { get; init; }
    public string PriceType { get; init; }
    public bool IsSellingPrice { get; init; }
    public DateRange DateRange { get; init; }
}
public record struct DateRange
{
    public DateTime From { get; init; }
    public DateTime To { get; init; }
}

