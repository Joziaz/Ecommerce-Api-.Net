using Ecommerce.Shared.Domain;
using System.Threading.Tasks;

namespace Ecommerce.BackOffice.Inventory.Domain
{
    public interface IProductRepository : ICRUDRepository<Product>
    {
        Task<Product[]> GetByCategory(Category category);
    }
}