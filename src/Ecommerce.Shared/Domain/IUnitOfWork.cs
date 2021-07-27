using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading.Tasks;

namespace Ecommerce.Shared.Domain
{
    public interface IUnitOfWork
    {
        Task SaveChanges();
        Task<IDbContextTransaction> BeginTransaction();
    }
}