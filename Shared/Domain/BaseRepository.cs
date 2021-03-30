using System.Threading.Tasks;
using api.Shared.Domain.Exeptions;
using api.Shared.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace api.Shared.Domain
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly PContext _context;
        private readonly DbSet<T> _provider;
        public BaseRepository(PContext context, DbSet<T> provider)
        {
            _context = context;
            _provider = provider;
        }

        public async Task<T[]> GetAll()
        {
            return await _provider.ToArrayAsync();
        }

        public async Task<T> Get(int id)
        {
            var result = await _provider.FindAsync(id);

            if (result == null)
                throw new RegistryNotFoundException();

            return result;
        }

        public async Task Create(T instance)
        {
            await _provider.AddAsync(instance);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T instance)
        {
            if (instance.Id == 0)
                throw new InvalidRegistryExecption();

            _provider.Update(instance);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _provider.SingleAsync( entity => entity.Id == id);

            if (entity == null)
                throw new RegistryNotFoundException();
            
            if (entity.IsDeleted == true)
                _provider.Remove(entity);
            else
            {
                entity.IsDeleted = true;
                _provider.Update(entity);   
            }

            await _context.SaveChangesAsync();
        }
    }
}