namespace GraphQLServer.API.GraphQL.Types;
public class InventoryType : ObjectType<Models.DTOs.Inventory>
{
    protected override void Configure(IObjectTypeDescriptor<Models.DTOs.Inventory> descriptor)
    {
        descriptor
            .Field(f => f.Quantity)
            .Description("inventory quantity ");
    }
}
