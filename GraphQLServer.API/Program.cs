using HotChocolate.Execution.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer()
            .AddApolloTracing(TracingPreference.Always);
            //.AddQueryType<Query>()
            //.AddType<LinkedProductType>()
            //.AddDataLoader<PriceDataLoader>()
            //.AddType<ProductDescriptionType>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGraphQL();
app.Run();
