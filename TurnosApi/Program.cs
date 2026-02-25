using Turnos.Application.Services;
using Turnos.Domain.Interface;
using Turnos.Infraestructura.Repositories;
using Microsoft.EntityFrameworkCore;
using Turnos.Infraestructura;
using Turnos.Infraestructura.Repositories;




var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TurnosDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddScoped<IPacienteRepository, PacienteRepository>();





// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//inyeccion de dependecias
builder.Services.AddScoped<ITurnoRepository, TurnoRepository>();
builder.Services.AddScoped<TurnoService>();

builder.Services.AddScoped<PacienteService>();



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

