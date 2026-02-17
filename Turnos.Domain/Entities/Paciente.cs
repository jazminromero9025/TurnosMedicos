using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Turnos.Domain.Entities
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Name { get;  set; }

        public Paciente(int Id, string name)
        {
            this.Id = Id;
            this.Name = name;
        }

        public Paciente()
        {

        }
















    }
}
