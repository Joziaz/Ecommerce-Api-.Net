using Ecommerce.BackOffice.Inventory.Domain;
using Ecommerce.BackOffice.Shared.Infrastructure;
using Ecommerce.Shared.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.BackOffice.Inventory.Infrastucture
{
    public class ProductRepository : CRUDRepository<Product>, IProductRepository
    {
        public ProductRepository(BackOfficeContext context) : base(context)
        {
        }

        public async Task<Product[]> GetByCategory(Category category)
        {
            var result = _provider.Where(product => product.Category == category);
            return await result.ToArrayAsync();
        }
    }
}