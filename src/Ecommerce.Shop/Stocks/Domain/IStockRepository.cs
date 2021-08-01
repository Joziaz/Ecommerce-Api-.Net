using Ecommerce.Shared.Domain;
using Ecommerce.Shop.Products.Domain;
using System.Threading.Tasks;

namespace Ecommerce.Shop.Stocks.Domain
{
    public interface IStockRepository : ICRUDRepository<Stock>
    {
        Task<Stock> GetByProduct(Product product);
    }
}