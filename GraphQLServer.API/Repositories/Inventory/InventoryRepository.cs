namespace GraphQLServer.API.Repositories.Inventory;
public class InventoryRepository : IInventoryRepository
{
    public async Task<Models.Entities.Inventory> GetInventoryByProductIdAsync(string productId)
    {
        return await Task.FromResult(new Models.Entities.Inventory()
        {
            Quantity = 10
        });
    }
}
