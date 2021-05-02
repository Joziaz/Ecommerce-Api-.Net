using System.Threading.Tasks;
using api.Inventory.Domain;
using api.Products.Infrastructure.Persistance;

namespace api.Inventory.Application
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

        public async Task DeleteProduct(Product product)
        {
            var stock = await Unit.StockRepository.GetByProduct(product);

            await Unit.BeginTransaction();
            try
            {
                await Unit.ProductRepository.Delete(product.Id);
                
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}