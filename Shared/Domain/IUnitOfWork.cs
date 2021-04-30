using System;
using System.Threading.Tasks;

namespace api.Shared.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        Task BeginTransaction();    
        Task Commit();    
        Task SaveChanges();    
        Task RollBack();    
    } 
}