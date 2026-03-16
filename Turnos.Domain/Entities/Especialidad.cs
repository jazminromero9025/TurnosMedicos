using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnos.Domain.Entities
{
    public class Especialidad
    {
        
        public int Id { get; set; }

        public string Nombre { get; set; }
        public Especialidad(string nombre, int id)
        {
            this.Nombre = nombre;
            this.Id = id;

        }

        public Especialidad()
        {

        }



    }
}
