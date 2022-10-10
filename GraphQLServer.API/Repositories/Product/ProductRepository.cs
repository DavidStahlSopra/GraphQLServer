namespace GraphQLServer.API.Repositories.ProductService;
public class ProductRepository : IProductRepository
{
    public async Task<Product> AddProductAsync(Product entityProduct)
    {
        Random random = new Random();

        int randomNumber = random.Next(1000, 9999);

        entityProduct.Id = randomNumber.ToString();
        return await Task.FromResult(entityProduct);
    }

    public async Task<Product> GetProductByIdAsync(string id)
    {
        return await Task.FromResult(GetAllProducts().SingleOrDefault(product => product.Id == id));
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return await Task.FromResult(GetAllProducts());
    }

    private IEnumerable<Product> GetAllProducts()
    {
        return new List<Product>
        {
            new Product
            {
                Id = "1234",
                Name = "GoPro HERO 10 Black actionkamera",
                Images = new List<Image>
                  {
                      new ()
                      {
                           AltText = "GoPro HERO 10 Black actionkamera",
                           Url = "https://images.clasohlson.com/medias/sys_master/h55/hd6/68117625110558.jpg",

                      },
                      new ()
                      {
                           AltText = "GoPro HERO 10 Black actionkamera",
                           Url = "https://images.clasohlson.com/medias/sys_master/h68/h23/68117625307166.jpg"
                      }
                  },
                Brand = new()
                {
                    Image = new()
                    {
                        AltText = "GoPro",
                        Url = "https://images.clasohlson.com/medias/sys_master/h25/h91/9670006276126.png"
                    },
                    Name = "GoPro"
                },
                Description = "Skapa och dela foto och film i stående eller liggande format. GoPro Hero 10 är en actionkamera med flera funktioner som har förbättrats från föregångaren GoPro Hero 9. Kristallklart resultat både i rörelse och under vatten."
            },
            new Product
            {
                Id = "4321",
                Name = "GoPro HERO 12 Black actionkamera",
                Images = new List<Image>
                  {
                      new ()
                      {
                           AltText = "GoPro HERO 12 Black actionkamera",
                           Url = "https://images.clasohlson.com/medias/sys_master/h55/hd6/68117625110558.jpg",

                      },
                      new ()
                      {
                           AltText = "GoPro HERO 12 Black actionkamera",
                           Url = "https://images.clasohlson.com/medias/sys_master/h68/h23/68117625307166.jpg"
                      }
                  },
                Brand = new()
                {
                    Image = new()
                    {
                        AltText = "GoPro",
                        Url = "https://images.clasohlson.com/medias/sys_master/h25/h91/9670006276126.png"
                    },
                    Name = "GoPro"
                },
                Description = "Skapa och dela foto och film i stående eller liggande format. GoPro Hero 10 är en actionkamera med flera funktioner som har förbättrats från föregångaren GoPro Hero 9. Kristallklart resultat både i rörelse och under vatten."
            },
            new Product
            {
                Id = "1111",
                Name = "GoPro HERO 11 Black actionkamera",
                Images = new List<Image>
                  {
                      new ()
                      {
                           AltText = "GoPro HERO 11 Black actionkamera",
                           Url = "https://images.clasohlson.com/medias/sys_master/h55/hd6/68117625110558.jpg",

                      },
                      new ()
                      {
                           AltText = "GoPro HERO 11 Black actionkamera",
                           Url = "https://images.clasohlson.com/medias/sys_master/h68/h23/68117625307166.jpg"
                      }
                  },
                Brand = new()
                {
                    Image = new()
                    {
                        AltText = "GoPro",
                        Url = "https://images.clasohlson.com/medias/sys_master/h25/h91/9670006276126.png"
                    },
                    Name = "GoPro"
                },
                Description = "Skapa och dela foto och film i stående eller liggande format. GoPro Hero 10 är en actionkamera med flera funktioner som har förbättrats från föregångaren GoPro Hero 9. Kristallklart resultat både i rörelse och under vatten."
            },
        };
    }
}
