

using System.Linq.Expressions;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        //T Get(int id);
        T Get(Expression<Func<T, bool>> filter);
        //void Update(T entity);
        void Remove(T entity);  
        void Add(T entity); 
        void RemoveRange(IEnumerable<T> entity);

    }
}
