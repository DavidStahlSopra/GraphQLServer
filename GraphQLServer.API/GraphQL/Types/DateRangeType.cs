namespace GraphQLServer.API.GraphQL.Types;
public class DateRangeType : ObjectType<Models.DTOs.DateRange>
{
    protected override void Configure(IObjectTypeDescriptor<Models.DTOs.DateRange> descriptor)
    {
        descriptor
            .Field(f => f.From)
            .Description("Interval start date");
        descriptor
            .Field(f => f.To)
            .Description("Interval end date");
    }
}
