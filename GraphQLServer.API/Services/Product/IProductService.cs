namespace GraphQLServer.API.Services.Product
{
    public interface IProductService
    {
        Task<Models.DTOs.Product> GetProductAsync(string productId);
        Task<Models.DTOs.Product> AddProductAsync(Models.DTOs.Product product);
    }
}
