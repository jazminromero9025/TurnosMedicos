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
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;

        public string Dni { get; set; } = null!;

        public string Telefono { get; set; } = null!;

        public string? Email { get; set; }





        public Paciente(int Id, string name, string apellido, string dni, string telefono, string email)
        {
            this.Id = Id;
            this.Nombre = name;
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
