using Microsoft.EntityFrameworkCore;
using Modules.Food.Entities;
using Shared.DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Food.DAL
{
    internal class DishDbContext : ModuleDbContext, IDishDbContext
    {
        protected override string Schema => "Dish";
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
