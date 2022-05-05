using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PooPlanner.Domain.DataAccess;
using PooPlanner.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPlanner.Domain.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomainLayer(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<PooPlannerContext>(options => options.UseSqlServer(
                config.GetConnectionString("Default"), 
                options => options.EnableRetryOnFailure()));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            return services;
        }
    }
}
