using System.Threading.Tasks;
using api.Inventory.Domain;
using api.Shared.Domain;
using api.Shared.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace api.Products.Infrastructure.Persistance
{
    public class ProductRepository : CRUDRepository<Product>, IProductRepository
    {
        public ProductRepository(PContext context, DbSet<Product> provider) : base(context)
        {
        }

        public async Task<Product[]> GetByCategory(Category category)
        {
            var result =_provider.Where( product => product.Category == category);
            return await result.ToArrayAsync();
        }
    }
}