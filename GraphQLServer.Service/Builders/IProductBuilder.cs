namespace GraphQLServer.Service.Builders;
public interface IProductBuilder
{
    public string GetId(Model.Entities.Product product);
    public string GetName(Model.Entities.Product product);
    public string GetDescription(Model.Entities.Product product);
    public Model.DTOs.Brand Getbrand(Model.Entities.Product product);
    public IEnumerable<Model.DTOs.Image> GetImages(Model.Entities.Product product);
}
