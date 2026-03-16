using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnos.Domain.Interface;
using Turnos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Turnos.Infraestructura.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly TurnosDbContext _context;

        public MedicoRepository(TurnosDbContext context)
        {
            this._context = context;
        }
        
        public async Task AgregarMedico(Medico medico)
        {
            _context.Medico.Add(medico);
            await _context.SaveChangesAsync();
        }


        public async Task <List<Medico>> ObtenerTodos()
        {
            return await _context.Medico.ToListAsync();
        }

        public async Task<Medico> ObtenerPorId(int id)
        {
            return await _context.Medico.FindAsync(id);
        }


        public async Task EliminarMedico(int id)
        {
            var medico = await _context.Medico.FindAsync(id);
            if(medico != null)
            {
                _context.Medico.Remove(medico);
                await _context.SaveChangesAsync();

            }
        }


        public async Task ActualizarMedico (Medico medico)
        {
            _context.Medico.Update(medico);
            await _context.SaveChangesAsync();


    }
    }
}
