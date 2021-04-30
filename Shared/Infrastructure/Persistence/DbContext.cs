using Microsoft.EntityFrameworkCore;

namespace api.Shared.Infrastructure.Persistance
{
    public class PContext : DbContext
    {
        public PContext(DbContextOptions<PContext> options) : base(options)
        {
        }
    }
}