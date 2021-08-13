using System.Linq;
using Ecommerce.BackOffice.Infrastructure.Persistance;
using Ecommerce.BackOffice.Inventory.Domain;
using System.Threading.Tasks;

namespace Ecommerce.BackOffice.Inventory.Application
{
    public class ProductService
    {
        private readonly UnitOfProducts Unit;

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

        public async Task DeleteProduct(int id)
        {
            await Unit.ProductRepository.Delete(id);
            await Unit.StockRepository.DeleteByProduct(id);
        }

        public async Task<Product> GetProduct(int id)
        {
            var product = await Unit.ProductRepository.Get(id);
            return product;
        }

        public async Task<Product[]> GetAll()
        {
            return await Unit.ProductRepository.GetAll();
        }

        public async Task Update(Product product)
        {
            await Unit.ProductRepository.Update(product);
        }

    }
}