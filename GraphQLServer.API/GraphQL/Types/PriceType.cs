namespace GraphQLServer.API.GraphQL.Types;
public class PriceType : ObjectType<Models.DTOs.Price>
{
    protected override void Configure(IObjectTypeDescriptor<Models.DTOs.Price> descriptor)
    {
        descriptor
            .Field(f => f.IsSellingPrice)
            .Description("Indicator if the price is the selling price");
        descriptor
            .Field(f => f.PriceType)
            .Description("Specifies the price type");
        descriptor
            .Field(f => f.Amount)
            .Description("specifies the price");
        descriptor
            .Field(f => f.DateRange)
            .Description("The price is valid in this interval");
    }
}
