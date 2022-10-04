namespace GraphQLServer.API.GraphQL.Resolvers;
public class ProductResolver
{
    public async Task<IEnumerable<Models.DTOs.Price>> GetPrices(IResolverContext context, [Service] IPriceService priceService)
    {
        var product = context.Parent<Models.DTOs.Product>();

        return await priceService.GetPricesAsync(product.Id);
    }
    public async Task<Models.DTOs.Inventory> GetInventory(IResolverContext context, [Service] IInventoryService inventoryService)
    {
        var product = context.Parent<Models.DTOs.Product>();

        return await inventoryService.GetInventoryAsync(product.Id);
    }
    public async Task<Models.DTOs.Rating> GetRating(IResolverContext context, [Service] IRatingService ratingService)
    {
        var product = context.Parent<Models.DTOs.Product>();

        return await ratingService.GetRatingAsync(product.Id);
    }
}
