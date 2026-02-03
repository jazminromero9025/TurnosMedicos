using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnos.Domain.Entities;

namespace Turnos.Domain.Interface
{
    public interface ITurnoRepository
    {
        void Crear( Turno turno);
        Turno ObtenerPorId(int Id);
        List<Turno> Lista();
        void Actualizar(Turno turno);
        void Eliminar(Turno turno);



    }
}
