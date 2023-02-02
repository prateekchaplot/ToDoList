using System.Collections;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ToDoList.Data.Repositories;

namespace ToDoList.Data;

public static class Extensions
{
    public static void AddDatabase(this IServiceCollection services, string connStr)
    {
        var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        
        // Add in memory database
        if (env.Equals("development", StringComparison.OrdinalIgnoreCase))
        {
            services.AddDbContext<TodoContext>(x => x.UseInMemoryDatabase(connStr));
        }
        
        // Add persistent database
        else if (env.Equals("production", StringComparison.OrdinalIgnoreCase))
        {
            services.AddDbContext<TodoContext>(x => x.UseSqlite(connStr));
        }
    }

    public static void AddRepository(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
    }

    public static void MigrateDatabase(this IServiceProvider serviceProvider)
    {
        using var context = serviceProvider.GetRequiredService<TodoContext>();
        context.Database.Migrate();
    }
}