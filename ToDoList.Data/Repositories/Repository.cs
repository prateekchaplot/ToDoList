using Microsoft.EntityFrameworkCore;

namespace ToDoList.Data.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly TodoContext _context;
    private readonly DbSet<T> _set;

    public Repository(TodoContext context)
    {
        _context = context;
        _set = _context.Set<T>();
    }

    public async Task<T> AddAsync(T item)
    {
        await _set.AddAsync(item);
        await SaveChangesAsync();
        return item;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _set.ToListAsync();
    }

    private async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}