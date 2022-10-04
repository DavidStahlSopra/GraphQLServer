using GraphQLServer.API.Repositories.Rating;

namespace GraphQLServer.API.Services.Rating;
public class RatingService : IRatingService
{
    private readonly IRatingRepository _ratingRepository;

    public RatingService(IRatingRepository ratingRepository)
    {
        _ratingRepository = ratingRepository;
    }
    public async Task<Models.DTOs.Rating> GetRatingAsync(string productId)
    {
        var rating = await _ratingRepository.GetRatingByProductIdAsync(productId);

        return BuildRating(rating);
    }

    private Models.DTOs.Rating BuildRating(Models.Entities.Rating rating)
    {
        return new()
        {
            Number = rating.Number,
            Score = rating.Score,
        };
    }
}
