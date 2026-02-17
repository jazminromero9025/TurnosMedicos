using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnos.Domain.Entities;
using Turnos.Domain.Interface;


namespace Turnos.Infraestructura.Repositories
{
    public class TurnoRepository : ITurnoRepository
    {
        private readonly TurnosDbContext _context;

        public TurnoRepository(TurnosDbContext context)
        {
            _context = context;
        }


        public void Crear(Turno turno)
        {
            _context.Turno.Add(turno);
            _context.SaveChanges();
        }


        public Turno ObtenerPorId(int id)
        {
            return _context.Turno.FirstOrDefault(t => t.Id == id);

        }


        public List<Turno> Lista()
        {
            return _context.Turno.ToList();
        }


        public void Actualizar(Turno turno)
        {
            _context.Turno.Update(turno);
            _context.SaveChanges();
                           
        }

        public void Eliminar(Turno turno)
        {
            _context.Turno.Remove(turno);
            _context.SaveChanges();
        }


    }
}
