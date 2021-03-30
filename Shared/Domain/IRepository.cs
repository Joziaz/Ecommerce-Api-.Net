using System.Threading.Tasks;

namespace api.Shared.Domain
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> Get(int id);
        Task<T[]> GetAll();
        Task Create(T instance);
        Task Update(T instance);
        Task Delete(int id);
    }
}