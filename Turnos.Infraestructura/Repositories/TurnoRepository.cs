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
        private List<Turno> turnos = new List<Turno>();

        public void Crear(Turno turno)
        {
            turnos.Add(turno);
        }


        public Turno ObtenerPorId(int id)
        {
            foreach (Turno turno in turnos)
            {
                if(turno.Id == id)
                {
                    return turno;
                }
            }
            return null;

        }


        public List<Turno> Lista()
        {
            return this.turnos;
        }


        public void Actualizar(Turno turno)
        {
            var existente = ObtenerPorId(turno.Id);

            if(existente!= null)
            {
                existente.fecha = turno.fecha;
                existente.Especialidad = turno.Especialidad;
                existente.PacienteId = turno.PacienteId;
                existente.MedicoId = turno.MedicoId;
            }
                           
        }

        public void Eliminar(Turno turno)
        {
            Turno turnoEliminado = ObtenerPorId(turno.Id);
            if(turnoEliminado != null)
            {
                turnos.Remove(turnoEliminado);
            }
        }


    }
}
