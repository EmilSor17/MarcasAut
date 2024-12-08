using MarcasAut.Core.Interfaces;
using MarcasAut.Infraestructure.Data;
using MarcasAut.Infraestructure.Persistence;
using MarcasAut.Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configuration = builder.Configuration;

//Conneccion a DB,primero buscada como variable de
//ambiente en Docker File, luego en appsettings
string connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING") ??
  configuration.GetConnectionString("TestDB");

builder.Services.AddDbContext<DatContext>(options =>
  options.UseNpgsql(connectionString));

//repositories
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IMarcasRepository, MarcasRepository>();

//Uso de CQRS
builder.Services.AddCors(options =>
{
  options.AddPolicy("AllowAll",
      builder =>
      {
        builder.AllowAnyOrigin()
                     .AllowAnyMethod()
                     .AllowAnyHeader();
      });
});
var app = builder.Build();

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
