using Microsoft.EntityFrameworkCore;
using Modules.Dishes.Core.Abstractions;
using Modules.Food.Core.Entities;
using Shared.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Dishes.Infrastructure.Persistence
{
    internal class DishDbContext : ModuleDbContext, IDishDbContext
    {
        public string Schema => "Dish";
        public DishDbContext(DbContextOptions<DishDbContext> options) : base(options)
        {
        }
        public DbSet<Dish> Dishes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
