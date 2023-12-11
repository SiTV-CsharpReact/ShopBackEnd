using ShopBackEnd.Entities;

namespace ShopBackEnd.Data
{
    public class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;
            var products = new List<Product>
            {
               new Product
    {
        Id = 1,
        Name = "Điện thoại iPhone 13",
        Description = "Sản phẩm điện thoại mới nhất của Apple",
        Price = 25000000,
        PictureUrl = "https://example.com/iphone13.jpg",
        Type = "Điện thoại di động",
        Brand = "Apple",
        QuantityInStock = "30"
    },
    new Product
    {
        Id = 2,
        Name = "Laptop Spectre x360",
        Description = "Laptop 2 trong 1 với màn hình cảm ứng",
        Price = 30000000,
        PictureUrl = "https://example.com/spectrex360.jpg",
        Type = "Laptop",
        Brand = "HP",
        QuantityInStock = "15"
    },
    new Product
    {
        Id = 3,
        Name = "Tai nghe Sony WH-1000XM4",
        Description = "Tai nghe chống ồn cao cấp",
        Price = 5000000,
        PictureUrl = "https://example.com/sonywh1000xm4.jpg",
        Type = "Tai nghe",
        Brand = "Sony",
        QuantityInStock = "25"
    },
    new Product
    {
        Id = 4,
        Name = "Smartwatch Galaxy Watch 4",
        Description = "Đồng hồ thông minh của Samsung",
        Price = 7000000,
        PictureUrl = "https://example.com/galaxywatch4.jpg",
        Type = "Đồng hồ thông minh",
        Brand = "Samsung",
        QuantityInStock = "20"
    },
    new Product
    {
        Id = 5,
        Name = "Máy ảnh Canon EOS R5",
        Description = "Máy ảnh mirrorless chuyên nghiệp",
        Price = 35000000,
        PictureUrl = "https://example.com/canoneosr5.jpg",
        Type = "Máy ảnh",
        Brand = "Canon",
        QuantityInStock = "10"
    }
            };
            foreach (var product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();
        }

    }
}
