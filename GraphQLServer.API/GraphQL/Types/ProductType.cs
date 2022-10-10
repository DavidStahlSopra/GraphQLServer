using GraphQLServer.API.GraphQL.Resolvers;

namespace GraphQLServer.API.GraphQL.Types;

public class ProductType : ObjectType<Models.DTOs.Product>
{
    protected override void Configure(IObjectTypeDescriptor<Models.DTOs.Product> descriptor)
    {
        descriptor
           .Field(f => f.Name)
           .Description("Name of the product");
        descriptor
           .Field(f => f.Brand)
           .Description("Product brand");
        descriptor
           .Field(f => f.Description)
           .Description("Product description");
        descriptor
           .Field(f => f.Images)
           .Description("Images of the product");
        descriptor
           .Field(f => f.Prices)
           .ResolveWith<ProductResolver>(r => r.GetPrices(default, default))
           .Description("List of product prices");
        descriptor
           .Field(f => f.Inventory)
           .ResolveWith<ProductResolver>(r => r.GetInventory(default, default))
           .Description("Product inventory information");
        descriptor
           .Field(f => f.Rating)
           .ResolveWith<ProductResolver>(r => r.GetRating(default, default))
           .Description("Product rating");

    }
}
