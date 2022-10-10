using GraphQLServer.API.GraphQL.Mutations;

namespace GraphQLServer.API.Extensions;
public static class ServiceExtension
{
    public static void AddAllServicesAsSingleton(this IServiceCollection services)
    {
        services.AddSingleton<IProductRepository, ProductRepository>();
        services.AddSingleton<IPriceRepository, PriceRepository>();
        services.AddSingleton<IInventoryRepository, InventoryRepository>();
        services.AddSingleton<IRatingRepository, RatingRepository>();
        services.AddSingleton<IProductService, ProductService>();
        services.AddSingleton<IPriceService, PriceService>();
        services.AddSingleton<IInventoryService, InventoryService>();
        services.AddSingleton<IPriceService, PriceService>();
        services.AddSingleton<IRatingService, RatingService>();
    }

    public static void AddGraphQLServerWithTypes(this IServiceCollection services)
    {
        services.AddGraphQLServer()
            .AddQueryType<Query>()
            .AddMutationType<Mutation>()
            .AddType<ProductType>()
            .AddType<DateRangeType>()
            .AddType<ImageType>()
            .AddType<InventoryType>()
            .AddType<PriceType>()
            .AddType<RatingType>()
            .AddType<BrandType>()
            .AddSorting()
            .AddFiltering();
    }
}
