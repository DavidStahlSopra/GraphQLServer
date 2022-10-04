namespace GraphQLServer.API.Repositories.Price;
public interface IPriceRepository
{
    Task<IEnumerable<Models.Entities.Price>> GetPricesByproductIdAsync(string productId);
}
