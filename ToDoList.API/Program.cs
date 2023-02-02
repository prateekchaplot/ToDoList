using ToDoList.API.Profiles;
using ToDoList.Data;

var builder = WebApplication.CreateBuilder(args);

var connStr = builder.Configuration.GetConnectionString("Database") ??
    throw new Exception("--> connection string 'Database' not found in appsettings!");

// Add services to the container.
builder.Services.AddAutoMapper(typeof(TodoMapper));
builder.Services.AddDatabase(connStr);
builder.Services.AddRepository();
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.Services.MigrateDatabase();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
