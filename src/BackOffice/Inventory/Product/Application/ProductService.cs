using Ecommerce.BackOffice.Inventory.Domain;
using Ecommerce.BackOffice.Infrastructure.Persistance;
using System.Threading.Tasks;

namespace Ecommerce.BackOffice.Inventory.Application
{
    public class ProductService
    {
        public readonly UnitOfProducts Unit;

        public async Task CreateProduct(Product product)
        {
            await Unit.BeginTransaction();
            try
            {
                var stock = new Stock(product, 0);
                await Unit.ProductRepository.Create(product);
                await Unit.StockRepository.Create(stock);
            }
            catch (System.Exception error)
            {
                await Unit.RollBack();
                throw new ProductCreationFailed(error.Message);
            }

        }

    }
}