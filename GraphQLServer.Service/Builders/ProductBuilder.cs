using GraphQLServer.Model.Entities;

namespace GraphQLServer.Service.Builders;
public class ProductBuilder : IProductBuilder
{
    public Model.DTOs.Brand Getbrand(Model.Entities.Product product)
    {
        return product.Brand is not null ? new()
        {
            Image = new()
            {
                AltText = product.Brand.Image.AltText,
                Url = product.Brand.Image.Url,
            },
            Name = product.Brand.Name,
        } : null;
    }
    public string GetDescription(Model.Entities.Product product)
    {
        return product.Description;
    }

    public string GetId(Model.Entities.Product product)
    {
        return product.Id;
    }

    public IEnumerable<Model.DTOs.Image> GetImages(Model.Entities.Product product)
    {
        return product.Images.Select(image => new Model.DTOs.Image
        {
             AltText= image.AltText,
             Url= image.Url,
        });
    }

    public string GetName(Model.Entities.Product product)
    {
        return product.Name;
    }
}
