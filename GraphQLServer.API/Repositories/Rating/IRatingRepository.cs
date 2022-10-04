namespace GraphQLServer.API.Repositories.Rating;
public interface IRatingRepository
{
    Task<Models.Entities.Rating> GetRatingByProductIdAsync(string productId);
}
