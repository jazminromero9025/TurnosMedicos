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
        public string Apellido { get; set; }

        public string Dni { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }





        public Paciente(int Id, string name, string apellido, string dni, string telefono, string email)
        {
            this.Id = Id;
            this.Name = name;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Telefono = telefono;
            this.Email = email;
        }

        public Paciente()
        {

        }
















    }
}
