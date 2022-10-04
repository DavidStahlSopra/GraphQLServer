namespace GraphQLServer.API.GraphQL.Queries;
public class Query
{
    [GraphQLName("Product")]
    [GraphQLDescription("Get product by id")]
    public async Task<Models.DTOs.Product> GetProduct(string id, [Service] IProductService productService)
    {
        return await productService.GetProductAsync(id);
    }
}
