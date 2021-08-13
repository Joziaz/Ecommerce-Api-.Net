using System.Net.Http.Headers;
using System.Diagnostics;
using Ecommerce.BackOffice.Inventory.Domain;
using Microsoft.Extensions.DependencyInjection;
using Ecommerce.BackOffice.Inventory.Infrastucture;
using Ecommerce.BackOffice.Orders.Infrastucture;
using Ecommerce.BackOffice.Orders.Domain;
using Ecommerce.BackOffice.Inventory.Application;
using Ecommerce.BackOffice.Infrastructure.Persistance;

namespace Ecommerce.Api.BackOffice.Extensions
{
    public static class DependenciesInjection
    {
        public static IServiceCollection AddBackOfficeDependencies(this IServiceCollection services)
        {

            services.AddScoped<IProductRepository,ProductRepository>();
            services.AddScoped<IStockRepository,StockRepository>();
            services.AddScoped<IOrderRepository,OrderRepository>();
            services.AddScoped<UnitOfProducts, UnitOfProducts>();
            services.AddScoped<StockService, StockService>();
            services.AddScoped<ProductService, ProductService>();

            return services;
        }
    }

}