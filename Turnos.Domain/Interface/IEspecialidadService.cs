using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnos.Domain.Entities;




namespace Turnos.Domain.Interface
{
    public interface IEspecialidadService
    {
        Task<IEnumerable<Especialidad>> ObtenerTodas();

        Task<Especialidad?> ObtenerPorId(int id);

        Task CrearEspecialidad(Especialidad especialidad);

        Task ActualizarEspecialidad(int id, Especialidad especialidad);

        Task EliminarEspecialidad(int id);

       

    }
}
