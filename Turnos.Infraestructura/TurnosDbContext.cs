using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Turnos.Domain.Entities;


namespace Turnos.Infraestructura
{
    public class TurnosDbContext : DbContext
    {

        public TurnosDbContext(DbContextOptions<TurnosDbContext> options) :base (options)
        {

        }

        public DbSet<Turno>  Turno { get; set; }

        public DbSet<Turno> Pacientes { get; set; }






    }
}
