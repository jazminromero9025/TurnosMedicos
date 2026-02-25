using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnos.Domain.Entities;

namespace Turnos.Domain.Interface
{
    public interface IPacienteRepository
    {
            Task AgregarPaciente(Paciente paciente);
            Task<Paciente> ObtenerPorId(int id);
            Task<List<Paciente>> ObtenerTodos();
            Task EliminarPaciente(int id);
      
    }
}
