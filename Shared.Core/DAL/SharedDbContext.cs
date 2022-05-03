using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataAccess.DAL
{
    internal class SharedDbContext : DbContext
    {
        public SharedDbContext(DbContextOptions<SharedDbContext> options) : base(options)
        {

        }
    }
}
