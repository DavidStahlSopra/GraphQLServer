namespace GraphQLServer.API.GraphQL.Queries;
public class Query
{
    [GraphQLName("GetProductById")]
    [GraphQLDescription("Get product by id")]
    public async Task<Models.DTOs.Product> GetProductById(string id, [Service] IProductService productService)
    {
        return await productService.GetProductByIdAsync(id);
    }
    [UsePaging]
    [UseFiltering]
    [UseSorting]
    [GraphQLName("GetAllProducts")]
    [GraphQLDescription("Get all products")]
    public async Task<IEnumerable<Models.DTOs.Product>> GetProducts([Service] IProductService productService)
    {
        return await productService.GetAllProductsAsync();
    }

}
