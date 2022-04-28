using Microsoft.EntityFrameworkCore;
using Modules.Dishes.Core.Abstractions;
using Modules.Food.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Dishes.Infrastructure.Persistence
{
    internal class DishDbContext : DbContext, IDishDbContext
    {
        public DishDbContext(DbContextOptions<DishDbContext> options) : base(options)
        {
        }
        public DbSet<Dish> Dishes { get; set; }

    }
}
