using Ecommerce.Shared.Domain.Exeptions;
using Ecommerce.Shared.Infrastructure.Persistance;
using Ecommerce.Shop.Products.Domain;
using Ecommerce.Shop.Stocks.Domain;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Ecommerce.Shop.Stocks.Infrastucture
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