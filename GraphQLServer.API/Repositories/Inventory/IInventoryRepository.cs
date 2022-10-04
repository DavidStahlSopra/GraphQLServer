namespace GraphQLServer.API.Repositories.Inventory;
public interface IInventoryRepository
{
    Task<Models.Entities.Inventory> GetInventoryByProductIdAsync(string productId);
}
