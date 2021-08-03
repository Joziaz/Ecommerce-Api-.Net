using Ecommerce.Shop.Products.Domain;
using Ecommerce.Shop.Stocks.Domain;
using System.Threading.Tasks;

namespace Ecommerce.Shop.Stocks.Application
{
    public class StockService
    {
        private readonly IStockRepository _repository;

        public StockService(IStockRepository repository)
        {
            _repository = repository;
        }

        public async Task SubtractStock(Product product, uint quantity)
        {
            var stock = await _repository.GetByProduct(product);
            stock.SubtractStock(quantity);
            await _repository.Update(stock);
        }
    }
}