using Ecommerce.Shared.Domain;
using Ecommerce.Shop.Products.Domain;
using System.Threading.Tasks;

namespace Ecommerce.Shop.Domain
{
    public interface IProductRepository : ICRUDRepository<Product>
    {
        Task<Product[]> GetByCategory(Category category);
    }
}