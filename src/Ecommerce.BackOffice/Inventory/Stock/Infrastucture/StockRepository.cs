using System;
using Ecommerce.BackOffice.Inventory.Domain;
using Ecommerce.Shared.Domain.Exeptions;
using Ecommerce.Shared.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.BackOffice.Shared.Infrastructure;

namespace Ecommerce.BackOffice.Inventory.Infrastucture
{
    public class StockRepository : CRUDRepository<Stock>, IStockRepository
    {
        public StockRepository(BackOfficeContext context) : base(context)
        {
        }

        public async Task<Stock> GetByProduct(Product product)
        {
            var stock = await _provider.FirstAsync(st => st.Product == product);

            if (stock == null)
                throw new NotFound("Stock of the product not found");

            return stock;
        }

        public async Task DeleteByProduct(int id)
        {
            var stock = await _provider.SingleOrDefaultAsync(stock => stock.Product.Id == id);
            await Delete(stock.Id);
        }

    }

}