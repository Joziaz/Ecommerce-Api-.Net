using Ecommerce.BackOffice.Inventory.Domain;
using Ecommerce.Shared.Domain.Exeptions;
using Ecommerce.Shared.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

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
                throw new NotFound("Stock of the product not found");

            return stock;
        }

    }
}