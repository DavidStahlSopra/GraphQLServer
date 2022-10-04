namespace GraphQLServer.API.Repositories.ProductService;
public interface IProductRepository
{
    public Task<Models.Entities.Product> GetProductByIdAsync(string id);
}
