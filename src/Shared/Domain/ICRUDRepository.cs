using System.Threading.Tasks;

namespace Ecommerce.Shared.Domain
{
    public interface ICRUDRepository<T> where T : BaseEntity
    {
        Task<T> Get(int id);
        Task<T[]> GetAll();
        Task Create(T instance);
        Task Delete(int id);
        Task Update(T instance);
    }
}