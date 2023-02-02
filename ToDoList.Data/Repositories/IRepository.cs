using System.Linq.Expressions;

namespace ToDoList.Data.Repositories;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> expression);
    Task<T> AddAsync(T item);
}