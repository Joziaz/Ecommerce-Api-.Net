using Ecommerce.BackOffice.Inventory.Domain;
using Ecommerce.BackOffice.Inventory.Infrastucture;
using System.Threading.Tasks;

namespace Ecommerce.BackOffice.Inventory.Application
{
    public class StockService
    {
        private readonly IStockRepository _repository;

        public StockService(IStockRepository repository)
        {
            _repository = repository;
        }

        public async Task AddToStock(Product product, uint quantity)
        {
            var stock = await _repository.GetByProduct(product);
            stock.AddToStock(quantity);
            await _repository.Update(stock);
        }

        public async Task SubstractStock(Product product, uint quantity)
        {
            var stock = await _repository.GetByProduct(product);
            stock.SubstractStock(quantity);
            await _repository.Update(stock);
        }
    }
}