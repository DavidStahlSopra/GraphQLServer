namespace GraphQLServer.API.GraphQL.Types;
public class BrandType : ObjectType<Models.DTOs.Brand>
{
    protected override void Configure(IObjectTypeDescriptor<Models.DTOs.Brand> descriptor)
    {
        descriptor
            .Field(f => f.Image)
            .Description("Brand image");
        descriptor
            .Field(f => f.Name)
            .Description("Brand name");
    }
}
