namespace GraphQLServer.API.Services.Product;
public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public async Task<Models.DTOs.Product> GetProductAsync(string id)
    {

        var product = await _productRepository.GetProductByIdAsync(id);

        return BuildProduct(product);
    }

    private Models.DTOs.Product BuildProduct(Models.Entities.Product product)
    {
        return new()
        {
            Brand = product.Brand is not null ? new()
            {
                Image = product.Brand.Image is not null ? new()
                {
                    AltText = product.Brand.Image.AltText,
                    Url = product.Brand.Image.AltText
                } : null,
                Name = product.Brand.Name
            } : null,
            Name = product.Name,
            Id = product.Id,
            Description = product.Description,
            Images = product.Images.Select(image => new Models.DTOs.Image
            {
                AltText = image.AltText,
                Url = image.Url,
            })
        };
    }
}
