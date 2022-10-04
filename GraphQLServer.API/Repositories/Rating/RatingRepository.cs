namespace GraphQLServer.API.Repositories.Rating;
public class RatingRepository : IRatingRepository
{
    public async Task<Models.Entities.Rating> GetRatingByProductIdAsync(string productId)
    {
        return await Task.FromResult(new Models.Entities.Rating
        {
             Number = 15,
             Score = 4.3
        });
    }
}
