using Lab6.Models;

namespace Lab6.Services.ProductsService
{
    public interface IProductsService
    {
        Task<IEnumerable<Product>> Get();
    }
}
