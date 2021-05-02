using System.Threading.Tasks;
using api.Inventory.Domain;
using api.Inventory.Infrastucture;

namespace api.Inventory.Application
{
    public class StockService
    {
        protected readonly StockRepository _repository;
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