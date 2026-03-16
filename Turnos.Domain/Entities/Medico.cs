using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnos.Domain.Entities
{
    public class Medico
    {
       
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public int EspecialidadId { get; set; }

        public Especialidad? Especialidad { get; set; } = null!;

        public Medico(string nombre, string apellido, int especialidad)
        {
            this.Nombre= nombre;
            this.Apellido = apellido;
            this.EspecialidadId = especialidad; 

        }





        public Medico()
        {

        }




    }
}
