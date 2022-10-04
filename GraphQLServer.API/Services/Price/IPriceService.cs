namespace GraphQLServer.API.Services.Price
{
    public interface IPriceService
    {
        Task<IEnumerable<Models.DTOs.Price>> GetPricesAsync(string productId);
    }
}
