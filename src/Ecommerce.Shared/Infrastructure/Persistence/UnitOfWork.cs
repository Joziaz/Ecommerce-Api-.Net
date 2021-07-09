using Ecommerce.Shared.Domain;
using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Tasks;

namespace Ecommerce.Shared.Infrastructure.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly PContext _context;
        protected readonly IDbContextTransaction _transaction;
        private bool disposedValue;

        public async Task BeginTransaction()
        {
            await _context.Database.BeginTransactionAsync();
        }

        public async Task Commit()
        {
            await _transaction.CommitAsync();
        }

        public async Task RollBack()
        {
            await _transaction.RollbackAsync();
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
                _transaction.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            System.GC.SuppressFinalize(this);
        }
    }
}