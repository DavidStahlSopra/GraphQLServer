namespace GraphQLServer.API.Services.Inventory;
public interface IInventoryService
{
    Task<Models.DTOs.Inventory> GetInventoryAsync(string productId);
}
