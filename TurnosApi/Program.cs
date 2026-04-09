using Microsoft.EntityFrameworkCore;
using Turnos.Application.Services;
using Turnos.Domain.Entities;
using Turnos.Domain.Interface;
using Turnos.Infraestructura;
using Turnos.Infraestructura.Repositories;

var builder = WebApplication.CreateBuilder(args);

// 🔥 CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});

// 🔥 DB
builder.Services.AddDbContext<TurnosDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 🔥 DEPENDENCIAS
builder.Services.AddScoped<IPacienteRepository, PacienteRepository>();
builder.Services.AddScoped<IPacienteService, PacienteService>();

builder.Services.AddScoped<IMedicoRepository, MedicoRepository>();
builder.Services.AddScoped<IMedicoService, MedicoService>();

builder.Services.AddScoped<IEspecialidadRepository, EspecialidadRepository>();
builder.Services.AddScoped<IEspecialidadService, EspecialidadService>();

builder.Services.AddScoped<ITurnoRepository, TurnoRepository>();
builder.Services.AddScoped<ITurnoService, TurnoService>();

// 🔥 Controllers + Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<TurnosDbContext>();

    if (!context.Especialidad.Any())
    {
        context.Especialidad.AddRange(
            new Especialidad { Nombre = "Clinica" },
            new Especialidad { Nombre = "Dermatologia" },
            new Especialidad { Nombre = "Cirugia" }
        );

        context.SaveChanges();
    }
}





// 🔥 Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 🔥 Middleware
app.UseHttpsRedirection();

app.UseCors("AllowAll"); // 👈 IMPORTANTE acá

app.UseAuthorization();

app.MapControllers();

app.Run();




