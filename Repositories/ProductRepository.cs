using WebAppMVC_1.Models;

namespace WebAppMVC_1.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products;

        public ProductRepository()
        {
            // Hardcoded list of 10 products
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 75000, Description = "High-performance laptop" },
                new Product { Id = 2, Name = "Smartphone", Price = 25000, Description = "Latest Android smartphone" },
                new Product { Id = 3, Name = "Headphones", Price = 3000, Description = "Noise-canceling headphones" },
                new Product { Id = 4, Name = "Monitor", Price = 15000, Description = "4K Ultra HD monitor" },
                new Product { Id = 5, Name = "Keyboard", Price = 2000, Description = "Mechanical keyboard" },
                new Product { Id = 6, Name = "Mouse", Price = 1000, Description = "Wireless optical mouse" },
                new Product { Id = 7, Name = "Tablet", Price = 20000, Description = "Portable Android tablet" },
                new Product { Id = 8, Name = "Smartwatch", Price = 8000, Description = "Fitness tracking smartwatch" },
                new Product { Id = 9, Name = "Printer", Price = 12000, Description = "Multifunction printer" },
                new Product { Id = 10, Name = "Speaker", Price = 5000, Description = "Bluetooth portable speaker" }
            };
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}
