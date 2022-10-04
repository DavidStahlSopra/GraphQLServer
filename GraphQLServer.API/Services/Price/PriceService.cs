namespace GraphQLServer.API.Services.Price;
public class PriceService : IPriceService
{
    private readonly IPriceRepository _priceRepository;

    public PriceService(IPriceRepository priceRepository)
    {
        _priceRepository = priceRepository;
    }
    public async Task<IEnumerable<Models.DTOs.Price>> GetPricesAsync(string productId)
    {
        var prices = await _priceRepository.GetPricesByproductIdAsync(productId);

        return BuildPrices(prices);
    }
    private IEnumerable<Models.DTOs.Price> BuildPrices(IEnumerable<Models.Entities.Price> prices)
    {
        return prices.Select(price => new Models.DTOs.Price
        {
            Amount = price.Amount,
            DateRange = price.DateRange is not null ? new()
            {
                From = price.DateRange?.From,
                To = price.DateRange?.To
            } : null,
            IsSellingPrice = price.IsSellingPrice,
            PriceType = price.PriceType,
        });
    }
}
