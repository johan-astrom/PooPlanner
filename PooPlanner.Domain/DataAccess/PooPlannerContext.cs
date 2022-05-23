using Microsoft.EntityFrameworkCore;
using PooPlanner.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooPlanner.Domain.DataAccess
{
    public class PooPlannerContext : DbContext
    {

        public PooPlannerContext(DbContextOptions<PooPlannerContext> options) : base(options)
        {
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Stool> Stools { get; set; }
    }
}
