var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServerWithTypes();
builder.Services.AddAllServicesAsSingleton();


var app = builder.Build();

app.UseHttpsRedirection();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL("/api/graphql");
});

app.MapGraphQL();

app.Run();
