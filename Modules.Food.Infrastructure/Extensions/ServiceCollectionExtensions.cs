using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Modules.Dishes.Core.Abstractions;
using Modules.Dishes.Infrastructure.Persistence;

namespace Shared.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDishesInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddDatabaseContext<DishDbContext>(configuration)
                .AddScoped<IDishDbContext>(provider => provider.GetService<DishDbContext>());
            return services;
        }
    }
}
