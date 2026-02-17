using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnos.Domain.Entities
{
    internal class Especialidad
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Especialidad(string name, int id)
        {
            this.Name = name;
            this.Id = id;

        }

        public Especialidad()
        {

        }



    }
}
