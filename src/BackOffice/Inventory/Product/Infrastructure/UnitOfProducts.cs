using Ecommerce.BackOffice.Inventory.Domain;
using Ecommerce.Shared.Infrastructure.Persistance;

namespace Ecommerce.BackOffice.Infrastructure.Persistance
{
    public class UnitOfProducts : UnitOfWork
    {
        public readonly IProductRepository ProductRepository;
        public readonly IStockRepository StockRepository;

    }
}