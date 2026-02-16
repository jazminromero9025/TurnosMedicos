using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Turnos.Domain.Entities;


namespace Turnos.Infraestructura
{
    internal class TurnosDbContext : DbContext
    {

        public TurnosDbContext(DbContextOptions<TurnosDbContext> options) :base (options)
        {

        }

        public DbSet<Turno>  turnos { get; set; }







    }
}
