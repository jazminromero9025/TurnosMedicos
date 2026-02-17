using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Turnos.Domain.Entities
{
    public class Turno
    {
        public int Id { get; set; }

        public int PacienteId { get; set; }

        public int MedicoId { get; set; }
        public DateTime FechaHora { get; set; }

        public  string Estado { get; set; }
        public int EspecialidadId { get; set; }
       

       

        public Turno(int Id, int pacienteId, int medicoId, DateTime fecha, string estado, int especialidad)
        {
            this.Id = Id;
            this.PacienteId = pacienteId;
            this.MedicoId = medicoId;
            this.FechaHora = fecha;
            this.Estado = estado;
            this.EspecialidadId = especialidad;
        }

        // Constructor vacío obligatorio para EF
        public Turno()
        {
        }


    }
}
