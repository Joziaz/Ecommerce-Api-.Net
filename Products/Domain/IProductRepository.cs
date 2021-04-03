using System.Threading.Tasks;
using api.Shared.Domain;

namespace api.Products.Domain
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product[]> GetByCategory(Category category);
    }
}