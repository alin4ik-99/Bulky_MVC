

using System.Linq.Expressions;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(string? includeProperties = null);
        //T Get(int id);
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null);
        //void Update(T entity);
        void Remove(T entity);  
        void Add(T entity); 
        void RemoveRange(IEnumerable<T> entity);

    }
}
