using Microsoft.EntityFrameworkCore;
using PooPlanner.Domain.DataAccess;
using PooPlanner.Domain.Entities;
using System.Linq.Expressions;

namespace PooPlanner.Domain.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : EntityBase
    {
        internal PooPlannerContext _context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(PooPlannerContext context)
        {
            _context = context;
            dbSet = _context.Set<TEntity>();
        }
        public TEntity Add(TEntity entity)
        {
            var createdEntity = _context.Add(entity);
            return createdEntity.Entity;
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().Where(expression);
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, object>>? includeExpression = null)
        {
            return dbSet.Include(includeExpression);
        }

        public TEntity GetById(long id, Expression<Func<TEntity, object>>? includeExpression = null)
        {
            return dbSet.Include(includeExpression).FirstOrDefault(e => e.Id == id);
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

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.RemoveRange(entities);
        }
    }
}
