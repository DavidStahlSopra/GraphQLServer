namespace GraphQLServer.API.Repositories.ProductService;
public interface IProductRepository
{
    Task<Models.Entities.Product> AddProductAsync(Product entityProduct);
    public Task<Models.Entities.Product> GetProductByIdAsync(string id);
    Task<IEnumerable<Product>> GetAllProductsAsync();
}
