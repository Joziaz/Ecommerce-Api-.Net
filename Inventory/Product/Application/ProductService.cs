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

        public async Task AddToStock(Product product, int quantity)
        {
            var stock = await Unit.StockRepository.GetByProduct(product);
            stock.AddToStock(quantity);
            await Unit.StockRepository.Update(stock);
        }

        public async Task SubstractStock(Product product, int quantity)
        {
            var stock = await Unit.StockRepository.GetByProduct(product);
            stock.SubstractStock(quantity);
            await Unit.StockRepository.Update(stock);
        }
    }
}