using Microsoft.EntityFrameworkCore;
using ProyectoDAM1.Exceptions;
using ProyectoDAM1.Models;
using ProyectoDAM1.Repositories;
using ProyectoDAM1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configurando el DBContext para usar el SQL Server
var connectionString = builder.Configuration.GetConnectionString("RestobarDB");
builder.Services.AddDbContext<RestobarCandelabroDBContext>(options => options.UseSqlServer(connectionString));

//Configurando la inyeccion de dependencia para ICustomerRepository
builder.Services.AddScoped<IMesaRepository, MesaService>();
builder.Services.AddScoped<IPlatoRepository, PlatoService>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Invocamos el GlobalExceptionHandler como middleware
app.UseMiddleware(typeof(GlobalExceptionHandler));

app.UseAuthorization();

app.MapControllers();

app.Run();
