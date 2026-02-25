using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Turnos.Domain.Entities;


namespace Turnos.Infraestructura
{
    public class TurnosDbContext : DbContext
    {

        public TurnosDbContext(DbContextOptions<TurnosDbContext> options) :base (options)
        {

        }

        public DbSet<Turno>  Turno { get; set; }

        public DbSet<Paciente> Pacientes { get; set; }

        public DbSet<Medico> Medicos { get; set; }

        public DbSet<Especialidad> Especialidades { get; set; }







    }
}
