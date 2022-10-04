namespace GraphQLServer.API.Services.Product
{
    public interface IProductService
    {
        public Task<Models.DTOs.Product> GetProductAsync(string productId);
    }
}
