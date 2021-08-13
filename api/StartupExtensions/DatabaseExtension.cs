using Ecommerce.BackOffice.Shared.Infrastructure;
using Ecommerce.Shop.Shared.Infrastucture;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Api.StartupExtensions
{
    public static class DatabaseExtension
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<BackOfficeContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("Database")));

            services.AddDbContext<ShopContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("Database")));


            return services;
        }

    }
}