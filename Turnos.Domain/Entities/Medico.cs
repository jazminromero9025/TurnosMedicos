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
        public string Name { get; set; }

        public string Apellido { get; set; }

        public int Especialidad { get;  set; }



        public Medico(string name,int id, string apellido, int especialidad)
        {
            this.Name = name;
            this.Id = id;
            this.Apellido = apellido;
            this.Especialidad = especialidad; 

        }





        public Medico()
        {

        }




    }
}
