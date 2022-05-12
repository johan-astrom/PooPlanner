using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PooPlanner.Domain.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(long id, Expression<Func<T, object>> includeExpression);
        IEnumerable<T> GetAll(Expression<Func<T, object>> includeExpression);
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        T Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(long id);
        void RemoveRange(IEnumerable<T> entities);
    }
}
