using Ecommerce.Shared.Domain;
using Ecommerce.Shared.Domain.Exeptions;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Ecommerce.Shared.Infrastructure.Persistance
{
    public abstract class CRUDRepository<T> : ICRUDRepository<T> where T : BaseEntity
    {

        protected readonly DbContext _context;
        protected readonly DbSet<T> _provider; 

        public CRUDRepository(DbContext context)
        {
            _context = context;
            _provider = _context.Set<T>();
        }

        public async Task<T> Get(int id)
        {
            var result = await _provider.FindAsync(id);

            if (result == null)
                throw new NotFound("Registry Not found");

            return result;
        }

        public async Task<T[]> GetAll()
        {
            return await _provider.ToArrayAsync();
        }
        public async Task Create(T instance)
        {
            instance.SetCreatedDate();
            await _provider.AddAsync(instance);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _provider.FindAsync(id);

            if (entity == null)
                throw new NotFound("Registry Not found");

            _provider.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T instance)
        {
            if (instance.Id == 0)
                throw new InvalidRegistryExecption("Invalid Registry");

            instance.SetModifiedDate();
            _provider.Update(instance);
            await _context.SaveChangesAsync();

        }
    }
}