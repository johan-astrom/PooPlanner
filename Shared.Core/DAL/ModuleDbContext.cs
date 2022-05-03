using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataAccess.DAL
{
    public abstract class ModuleDbContext : DbContext { 
        protected virtual string? Schema { get; }
        public ModuleDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (!string.IsNullOrWhiteSpace(Schema))
            {
                modelBuilder.HasDefaultSchema(Schema);
            }
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(true, cancellationToken);
        }

    }
}
