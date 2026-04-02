using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnos.Domain.Entities;

namespace Turnos.Domain.Interface
{
    public interface IPacienteService
    {
       
            Task CrearPaciente(Paciente paciente);
            Task<List<Paciente>> ObtenerTodos();
            Task<Paciente> ObtenerPorId(int id);
            Task EliminarPaciente(int id);


}
}
