using System.Threading.Tasks;
using api.Shared.Domain;

namespace api.Inventory.Domain
{
    public interface IProductRepository : ICRUDRepository<Product>
    {
        Task<Product[]> GetByCategory(Category category);
    }
}