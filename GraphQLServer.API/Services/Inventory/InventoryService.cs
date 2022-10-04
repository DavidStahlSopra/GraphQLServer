namespace GraphQLServer.API.Services.Inventory;
public class InventoryService : IInventoryService
{
    private readonly IInventoryRepository _inventoryRepository;

    public InventoryService(IInventoryRepository inventoryRepository)
    {
        _inventoryRepository = inventoryRepository;
    }
    public async Task<Models.DTOs.Inventory> GetInventoryAsync(string productId)
    {
        var inventory = await _inventoryRepository.GetInventoryByProductIdAsync(productId);

        return BuildInventory(inventory);
    }
    private Models.DTOs.Inventory BuildInventory(Models.Entities.Inventory inventory)
    {
        return new()
        {
            Quantity = inventory.Quantity
        };
    }
}
