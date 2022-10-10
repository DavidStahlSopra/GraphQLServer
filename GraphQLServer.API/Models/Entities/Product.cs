namespace GraphQLServer.API.Models.Entities;
public record Product
{
    public string Id { get; set; }
    public string Name { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public Brand Brand { get; init; }
    public IEnumerable<Image> Images { get; init; } = Enumerable.Empty<Image>();
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
