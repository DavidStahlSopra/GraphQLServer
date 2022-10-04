namespace GraphQLServer.API.GraphQL.Types;
public class ImageType : ObjectType<Models.DTOs.Image>
{
    protected override void Configure(IObjectTypeDescriptor<Models.DTOs.Image> descriptor)
    {
        descriptor
            .Field(f => f.AltText)
            .Description("image altText");
        descriptor
            .Field(f => f.Url)
            .Description("image source url");
    }
}
