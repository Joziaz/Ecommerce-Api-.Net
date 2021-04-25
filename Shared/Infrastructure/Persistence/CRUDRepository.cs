using System.Threading.Tasks;
using api.Shared.Domain;
using api.Shared.Domain.Exeptions;
using Microsoft.EntityFrameworkCore;

namespace api.Products.Infrastructure.Persistance
{
    public abstract class CRUDRepository<T> : ICRUDRepository<T> where T : BaseEntity
    {
        
        protected readonly DbContext _context;
        protected DbSet<T> _provider => _context.Set<T>();

        public CRUDRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<T> Get(int id)
        {
            var result = await _provider.FindAsync(id);

            if (result == null)
                throw new RegistryNotFoundException("Registry Not found");
            
            return result;
        }

        public async Task<T[]> GetAll()
        {
            return await _provider.ToArrayAsync();
        }
        public async Task Create(T instance)
        {
            if (instance.Id == 0)
                throw new InvalidRegistryExecption("Invalid Registry");

            await _provider.AddAsync(instance);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _provider.FindAsync(id);

            if (entity == null)
                throw new RegistryNotFoundException("Registry Not found");
            
            _provider.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T instance)
        {
            if (instance.Id == 0)
                throw new InvalidRegistryExecption("Invalid Registry");

            _provider.Update(instance);
            await _context.SaveChangesAsync();

        }
    }
}