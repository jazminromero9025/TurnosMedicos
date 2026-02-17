using Turnos.Application.Services;
using Turnos.Domain.Interface;
using Turnos.Infraestructura.Repositories;
using Microsoft.EntityFrameworkCore;
using Turnos.Infraestructura;




var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TurnosDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));





// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//inyeccion de dependecias
builder.Services.AddScoped<ITurnoRepository, TurnoRepository>();
builder.Services.AddScoped<TurnoService>();




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
