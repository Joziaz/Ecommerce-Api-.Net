using System.Threading.Tasks;
using Ecommerce.BackOffice.Inventory.Domain;
using Ecommerce.BackOffice.Inventory.Infrastucture;

namespace Ecommerce.BackOffice.Inventory.Application
{
    public class StockService
    {
        private readonly StockRepository _repository;
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