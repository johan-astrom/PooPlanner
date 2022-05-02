using Microsoft.EntityFrameworkCore;
using Shared.DataAccess.Interfaces;
using Shared.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Core.Repository
{
    internal class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        internal ModuleDbContext _context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(ModuleDbContext context)
        {
            _context = context;
            dbSet = _context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Find(System.Linq.Expressions.Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbSet;
        }

        public TEntity GetById(long id)
        {
            return dbSet.Find(id);
        }

        public void Remove(long id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            _context.Remove(entityToDelete);
        }

        public void RemoveRange(IEnumerable<long> ids)
        {
            throw new NotImplementedException();
        }
    }
}
