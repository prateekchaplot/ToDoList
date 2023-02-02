using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ToDoList.Data.Repositories;

namespace ToDoList.Data;

public static class Extensions
{
    public static void AddInMemoryDatabase(this IServiceCollection services)
    {
        services.AddDbContext<TodoContext>(x => x.UseInMemoryDatabase("ABC"));
    }

    public static void AddRepository(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
    }
}