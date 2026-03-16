using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnos.Domain.Entities;

namespace Turnos.Domain.Interface
{
    public interface IMedicoService
    {
        Task CrearMedico(Medico medico);

        Task<List<Medico>> ObtenerTodos();

        Task<Medico> ObtenerPorId(int id);

        Task EliminarMedico(int id);

        Task ActualizarMedico(Medico medico);
    }
}
