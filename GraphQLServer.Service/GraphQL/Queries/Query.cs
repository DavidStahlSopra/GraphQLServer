namespace GraphQLServer.Service.GraphQL.Queries;
public class Query
{
    [GraphQLName("Product")]
    [GraphQLDescription("Get product by productId")]
    public async Task GetProduct(string productId)
    {

    }
}
