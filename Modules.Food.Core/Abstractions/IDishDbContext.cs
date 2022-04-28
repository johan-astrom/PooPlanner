using Microsoft.EntityFrameworkCore;
using Modules.Food.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Dishes.Core.Abstractions
{
    public interface IDishDbContext
    {
        public DbSet<Dish> Dishes { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
