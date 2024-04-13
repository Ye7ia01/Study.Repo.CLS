using DAL;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repo.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbcontext>(options =>
                                            options.UseSqlServer(
                                                builder.Configuration.GetConnectionString("con"),
                                                 b => b.MigrationsAssembly(typeof(AppDbcontext).Assembly.FullName)
                                                ));
//builder.Services.AddTransient(typeof(IRepo<>),typeof(Repo<>));
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddCors();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(p => p.AllowAnyOrigin().AllowAnyMethod());
app.UseAuthorization();

app.MapControllers();

app.Run();
