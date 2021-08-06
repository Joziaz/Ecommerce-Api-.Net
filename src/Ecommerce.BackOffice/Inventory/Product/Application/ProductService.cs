using Ecommerce.BackOffice.Infrastructure.Persistance;
using Ecommerce.BackOffice.Inventory.Domain;
using System.Threading.Tasks;

namespace Ecommerce.BackOffice.Inventory.Application
{
    public class ProductService
    {
        public readonly UnitOfProducts Unit;

        public ProductService(UnitOfProducts unit)
        {
            Unit = unit;
        }

        public async Task CreateProduct(Product product)
        {
            using var transaction = await Unit.BeginTransaction();
            try
            {
                var stock = new Stock(product, 0);
                await Unit.ProductRepository.Create(product);
                await Unit.StockRepository.Create(stock);

                await transaction.CommitAsync();
            }
            catch (System.Exception error)
            {
                await transaction.RollbackAsync(); 
                throw new ProductCreationFailed(error.Message);
            }
        }

        public async Task DeleteProductAsync(int id)
        {
            await Unit.ProductRepository.Delete(id);
            await Unit.StockRepository.DeleteByProduct(id);
        }

    }
}