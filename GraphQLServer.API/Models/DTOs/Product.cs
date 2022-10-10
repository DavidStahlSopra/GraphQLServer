namespace GraphQLServer.API.Models.DTOs
{
    [GraphQLDescription("A product type")]
    public record Product
    {
        [GraphQLIgnore]
        public string Id { get; init; } = string.Empty;
        [GraphQLDescription("Name of the product")]
        public string Name { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public Brand Brand { get; init; }
        public IEnumerable<Image> Images { get; init; } = Enumerable.Empty<Image>();
        public Inventory Inventory { get; init; }
        public IEnumerable<Price> Prices { get; init; } = Enumerable.Empty<Price>();
        public Rating Rating { get; init; }
    }
    [GraphQLDescription("A price type")]
    public record Price
    {
        public double Amount { get; init; }
        public string PriceType { get; init; } = string.Empty;
        public bool IsSellingPrice { get; init; }
        public DateRange DateRange { get; init; }
    }
    [GraphQLDescription("A price date type")]
    public record DateRange
    {
        public DateTime? From { get; init; }
        public DateTime? To { get; init; }
    }
    [GraphQLDescription("A inventory type")]
    public record Inventory
    {
        public int Quantity { get; init; }
    }
    [GraphQLDescription("A brand type")]
    public record Brand
    {
        [GraphQLDeprecated("Use the `brandName` field instead")]
        public string Name { get; init; } = string.Empty;
        public string BrandName { get; init; } = string.Empty;
        public Image Image { get; init; }
    }
    [GraphQLDescription("A image type")]
    public record Image
    {
        public string AltText { get; init; } = string.Empty;
        public string Url { get; init; } = string.Empty;
    }
    [GraphQLDescription("A rating type")]
    public record Rating
    {
        public int Number { get; init; }
        public double Score { get; init; }
    }
}
