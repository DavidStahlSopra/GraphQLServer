namespace GraphQLServer.API.GraphQL.Types;
public class RatingType : ObjectType<Models.DTOs.Rating>
{
    protected override void Configure(IObjectTypeDescriptor<Models.DTOs.Rating> descriptor)
    {
        descriptor
            .Field(f => f.Number)
            .Description("Number of ratings");
        descriptor
            .Field(f => f.Score)
            .Description("Rating average score");
    }
}
