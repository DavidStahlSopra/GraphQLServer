namespace GraphQLServer.API.Repositories.Price;
public class PriceRepository : IPriceRepository
{
    public async Task<IEnumerable<Models.Entities.Price>> GetPricesByproductIdAsync(string productId)
    {
        return await Task.FromResult(new List<Models.Entities.Price>
        {
            new ()
            {
                Amount = 300.00,
                DateRange = new()
                {
                    From = DateTime.Parse("2022-09-08 10:00"),
                    To = DateTime.Parse("2022-12-31 10:00")
                },
                IsSellingPrice = true,
                PriceType = "ReaPris"
                  
            },
            new ()
            {
                Amount = 350.00,
                DateRange = new()
                {
                    From = DateTime.Parse("2022-09-08 10:00"),
                    To = DateTime.Parse("2022-12-31 10:00")
                },
                IsSellingPrice = false,
                PriceType = "ListPris"

            },
        });
    }
}
