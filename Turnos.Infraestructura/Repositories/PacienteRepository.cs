using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Turnos.Domain.Interface;

namespace Turnos.Infraestructura.Repositories
{
    public class PacienteRepository : IPacienteRepository    {
        private readonly TurnosDbContext _context;

        public PacienteRepository(TurnosDbContext context)
        {
            _context = context;
        }


        public async Task AgregarPaciente(Paciente paciente)
        {
            await _context.Pacientes.AddAsync(paciente);
            await _context.SaveChangesAsync();
        }

        public async Task<Paciente> ObtenerPorId(int id)
        {

            return await _context.Pacientes.FindAsync(id);
        }

        public async Task<List<Paciente>> ObtenerTodos()
        {
            return await _context.Pacientes.ToListAsync();
        }

        public async Task EliminarPaciente(int id)
        {
            var paciente = await _context.Pacientes.FindAsync(id);

            if(paciente == null)
            {
                _context.Pacientes.Remove(paciente);
                await _context.SaveChangesAsync();
            }

        }










    }
}
