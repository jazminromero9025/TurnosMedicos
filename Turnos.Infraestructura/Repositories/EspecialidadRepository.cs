using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnos.Domain.Entities;
using Turnos.Domain.Interface;
using Microsoft.EntityFrameworkCore;


namespace Turnos.Infraestructura.Repositories
{
    public class EspecialidadRepository : IEspecialidadRepository
    {
        private readonly TurnosDbContext _context;

        public EspecialidadRepository(TurnosDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Especialidad>> ObtenerTodas()
        {
            return await _context.Especialidad.ToListAsync();
        }

        public async Task<Especialidad?> ObtenerPorId(int id)
        {
            return await _context.Especialidad.FindAsync(id);
        }

        public async Task AgregarEspecialidad(Especialidad especialidad)
        {
            _context.Especialidad.Add(especialidad);
            await _context.SaveChangesAsync();
        }

        public async Task Eliminar(int id)
        {
            var especialidad = await _context.Especialidad.FindAsync(id);
            if (especialidad != null)
            {
                _context.Especialidad.Remove(especialidad);
                await _context.SaveChangesAsync();
            }
        }


        public async Task Actualizar(Especialidad especialidad)
        {
            _context.Especialidad.Update(especialidad);
            await _context.SaveChangesAsync();
        }







    }
}
