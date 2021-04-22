using System.Threading.Tasks;
using api.Shared.Domain;

namespace api.Inventory.Domain
{
    public interface IStockRepository : ICRUDRepository<Stock>
    {
        Task<Stock> GetByProduct(Product product);
    }
}