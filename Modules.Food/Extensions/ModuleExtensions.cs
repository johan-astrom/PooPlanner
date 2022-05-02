using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Modules.Food.DAL;
using Shared.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Food.Extensions
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddDishesModule(this IServiceCollection services, IConfiguration configuration)
        {
            services
                  .AddDatabaseContext<DishDbContext>(configuration)
                  .AddScoped<IDishDbContext>(provider => provider.GetService<DishDbContext>());
            return services;
        }

    }
}
