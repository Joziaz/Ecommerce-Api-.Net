using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Shared.Infrastructure.Persistance
{
    public class PContext : DbContext
    {
        public PContext(DbContextOptions<PContext> options) : base(options)
        {
        }
    }
}