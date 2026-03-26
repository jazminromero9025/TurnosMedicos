using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnos.Domain.Entities;

namespace Turnos.Domain.Interface
{
    public interface IEspecialidadRepository
    {
        Task<IEnumerable<Especialidad>> ObtenerTodas();

        Task<Especialidad?> ObtenerPorId(int id);

        Task AgregarEspecialidad(Especialidad especialidad);

        Task Actualizar(Especialidad especialidad);

        Task Eliminar(int id);




    }
}
