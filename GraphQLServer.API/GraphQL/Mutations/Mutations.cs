namespace GraphQLServer.API.GraphQL.Mutations;
public class Mutation
{
    public async Task<Models.DTOs.Product> AddProduct(Models.DTOs.Product product, [Service] IProductService productService)
    {
        return await productService.AddProductAsync(product);
    }
}
