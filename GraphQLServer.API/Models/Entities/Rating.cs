namespace GraphQLServer.API.Models.Entities;
public record struct Rating
{
    public int Number { get; init; }
    public double Score { get; init; }
}
