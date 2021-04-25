using System.Linq;
using System.Threading.Tasks;
using api.Inventory.Domain;
using api.Products.Infrastructure.Persistance;
using api.Shared.Domain.Exeptions;
using Microsoft.EntityFrameworkCore;

namespace api.Inventory.Infrastucture
{
    public class StockRepository : CRUDRepository<Stock>, IStockRepository
    {
        public StockRepository(DbContext context) : base(context)
        {
        }

        public async Task<Stock> GetByProduct(Product product)
        {
            var stock = await _provider.FirstAsync(st => st.Product == product);
            
            if (stock == null)
                throw new RegistryNotFoundException("Stock of the product not found");
            
            return stock;
        }

    }
}