using Ecommerce.BackOffice.Inventory.Domain;
using Ecommerce.Shared.Domain.Exeptions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Shared.Infrastructure.Persistance;

namespace Ecommerce.BackOffice.Inventory.Infrastucture
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