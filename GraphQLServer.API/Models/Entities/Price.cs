
namespace GraphQLServer.API.Models.Entities;
public record Price
{
    public double Amount { get; init; }
    public string PriceType { get; init; } = string.Empty;
    public bool IsSellingPrice { get; init; }
    public DateRange? DateRange { get; init; } = null;
}
public record struct DateRange
{
    public DateTime? From { get; init; }
    public DateTime? To { get; init; }
}

