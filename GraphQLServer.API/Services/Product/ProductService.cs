namespace GraphQLServer.API.Services.Product;
public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public async Task<Models.DTOs.Product> GetProductByIdAsync(string id)
    {

        var product = await _productRepository.GetProductByIdAsync(id);

        return BuildDTOProduct(product);
    }

    public async Task<IEnumerable<Models.DTOs.Product>> GetAllProductsAsync()
    {

        var products = await _productRepository.GetAllProductsAsync();

        return products.Select(product => BuildDTOProduct(product));
    }

    public async Task<Models.DTOs.Product> AddProductAsync(Models.DTOs.Product product)
    {
        var entityProduct = BuildEntityProduct(product);

        var addedProduct = await _productRepository.AddProductAsync(entityProduct);

        return BuildDTOProduct(addedProduct);
    }

    private Models.Entities.Product BuildEntityProduct(Models.DTOs.Product product)
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
                Name = string.IsNullOrEmpty( product.Brand.BrandName) ? product.Brand.Name : product.Brand.BrandName,
            } : null,
            Name = product.Name,
            Id = product.Id,
            Description = product.Description,
            Images = product.Images is not null ? product.Images.Select(image => new Models.Entities.Image
            {
                AltText = image.AltText,
                Url = image.Url,
            }) : Enumerable.Empty<Models.Entities.Image>()
        };
    }

    private Models.DTOs.Product BuildDTOProduct(Models.Entities.Product product)
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
                BrandName = product.Brand.Name,
                Name = product.Brand.Name
            } : null,
            Name = product.Name,
            Id = product.Id,
            Description = product.Description,
            Images = product.Images is not null ? product.Images.Select(image => new Models.DTOs.Image
            {
                AltText = image.AltText,
                Url = image.Url,
            }) : Enumerable.Empty<Models.DTOs.Image>()
        };
    }
}
