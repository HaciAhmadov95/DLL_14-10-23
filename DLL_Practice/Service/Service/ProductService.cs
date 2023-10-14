using Domain.Models;

namespace Service.Service
{
    public class ProductService
    {
        private Product[] GetAll()
        {
            return new Product[]
            {
                new Product {Id = 1,Name = "Iphone12" ,Price = 1000, Count = 10, },
                new Product {Id = 2,Name = "Iphone13" ,Price = 2000, Count = 20,},
                new Product {Id = 3, Name = "Iphone13" ,Price = 3000, Count = 30, },
            };
        }

        public Product[] GetAllByCount(int count)
        {
            Product[] products = GetAll();

            return products.Where(m => m.Count > count).ToArray();
        }

    }
}
