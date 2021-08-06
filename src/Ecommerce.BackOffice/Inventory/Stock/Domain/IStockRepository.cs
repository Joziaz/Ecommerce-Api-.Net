using Ecommerce.Shared.Domain;
using System.Threading.Tasks;

namespace Ecommerce.BackOffice.Inventory.Domain
{
    public interface IStockRepository : ICRUDRepository<Stock>
    {
        Task<Stock> GetByProduct(Product product);
        Task DeleteByProduct(int id);
    }
}