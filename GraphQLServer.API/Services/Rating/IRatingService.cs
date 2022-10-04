namespace GraphQLServer.API.Services.Rating
{
    public interface IRatingService
    {
        Task<Models.DTOs.Rating> GetRatingAsync(string productId);
    }
}
