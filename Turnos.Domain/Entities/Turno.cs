using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnos.Domain.Entities
{
    public class Turno
    {
        public int Id { get; set; }
        public DateTime fecha { get; set; }
        public string Especialidad { get; set; }
        public int PacienteId { get; set; }

        public int MedicoId { get; set; }

        public Turno(int Id, DateTime fecha, string especialidad, int pacienteId, int medicoId)
        {
            this.Id = Id;
            this.fecha = fecha;
            this.Especialidad = especialidad;
            this.PacienteId = pacienteId;
            this.MedicoId = medicoId;
        }




    }
}
