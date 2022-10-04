using GraphQLServer.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServerWithTypes();
builder.Services.AddAllServicesAsSingleton();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGraphQL();
app.Run();
