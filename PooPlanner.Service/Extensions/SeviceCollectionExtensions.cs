using Microsoft.Extensions.DependencyInjection;
using PooPlanner.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPlanner.Service.Extensions
{
    public static class SeviceCollectionExtensions
    {
        public static IServiceCollection AddServiceLayer(this IServiceCollection services)
        {
            services.AddScoped<IFoodService, FoodService>();
            services.AddScoped<IMedicineService, MedicineService>();
            services.AddScoped<IMedicationService, MedicationService>();
            return services;
        }
    }
}
