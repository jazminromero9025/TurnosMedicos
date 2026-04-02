using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnos.Domain.Entities;

namespace Turnos.Domain.Interface
{
    public interface ITurnoService
    {
     
            void CrearTurno(Turno turno);
            Turno ObtenerPorId(int id);
            List<Turno> ObtenerTurnos();
            void ActualizarTurno(Turno turno);
            void EliminarTurno(int id);

    }

}
