using Ecommerce.Shared.Infrastructure.Persistance;
using Ecommerce.Shop.Domain;
using Ecommerce.Shop.Products.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Shop.Infrastructure.Persistance
{
    public class ProductRepository : CRUDRepository<Product>, IProductRepository
    {
        public ProductRepository(PContext context, DbSet<Product> provider) : base(context)
        {
        }

        public async Task<Product[]> GetByCategory(Category category)
        {
            var result = _provider.Where(product => product.Category == category);
            return await result.ToArrayAsync();
        }
    }
}