using WebAppMVC_1.Models;

namespace WebAppMVC_1.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
    }
}
