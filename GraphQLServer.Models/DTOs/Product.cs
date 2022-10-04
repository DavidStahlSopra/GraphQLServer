namespace GraphQLServer.Model.DTOs
{
    public record Product
    {
        public string Id { get; init; } = string.Empty;
        public string Name { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public Brand Brand { get; init; }
        public IEnumerable<Image> Images { get; init; } = Enumerable.Empty<Image>();
        public Inventory Invesntory { get; init; }
        public IEnumerable<Price> Prices { get; init; } = Enumerable.Empty<Price>();
        public Rating Rating { get; init; }
    }
    public record Price
    {
        public double Amount { get; init; }
        public string PriceType { get; init; } = string.Empty;
        public bool IsSellingPrice { get; init; }
        public DateRange DateRange { get; init; }
    }
    public record DateRange
    {
        public DateTime From { get; init; }
        public DateTime To { get; init; }
    }
    public record Inventory
    {
        public int Quantity { get; init; }
    }
    public record Brand
    {
        public string Name { get; init; } = string.Empty;
        public Image Image { get; init; }
    }

    public record Image
    {
        public string AltText { get; init; } = string.Empty;
        public string Url { get; init; } = string.Empty;
    }
    public record Rating
    {
        public int Number { get; init; }
        public double Score { get; init; }
    }
}
