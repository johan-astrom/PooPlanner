using Microsoft.EntityFrameworkCore;
using Shared.DataAccess.DAL;

namespace Shared.DataAccess.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
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
            _context.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.AddRange(entities);
        }

        public IEnumerable<TEntity> Find(System.Linq.Expressions.Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().Where(expression);
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

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.RemoveRange(entities);
        }
    }
}
