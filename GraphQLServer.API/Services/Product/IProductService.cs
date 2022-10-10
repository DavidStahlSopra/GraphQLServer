namespace GraphQLServer.API.Services.Product
{
    public interface IProductService
    {
        Task<Models.DTOs.Product> GetProductByIdAsync(string productId);
        Task<Models.DTOs.Product> AddProductAsync(Models.DTOs.Product product);
        Task<IEnumerable<Models.DTOs.Product>> GetAllProductsAsync();
    }
}
