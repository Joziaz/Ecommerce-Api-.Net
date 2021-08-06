using Ecommerce.Shared.Domain;
using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Tasks;

namespace Ecommerce.Shared.Infrastructure.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly PContext _context;

        public UnitOfWork(PContext context)
        {
            _context = context;
        }

        public async Task<IDbContextTransaction> BeginTransaction()
        {
            return await _context.Database.BeginTransactionAsync();
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}