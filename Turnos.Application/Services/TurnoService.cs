using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnos.Domain.Entities;
using Turnos.Domain.Interface;

namespace Turnos.Application.Services
{
    public class TurnoService
    {
        private readonly ITurnoRepository _TurnoRepository;

        public TurnoService(ITurnoRepository turnoRepository)
        {
            this._TurnoRepository = turnoRepository;
        }


        public void CrearTurno(Turno turno)
        {

            _TurnoRepository.Crear(turno);

        }


        public Turno ObtenerPorId(int id)
        {
            return _TurnoRepository.ObtenerPorId(id);
        }


        public List<Turno> ObtenerTurnos()
        {
            return _TurnoRepository.Lista();
        }


        public void ActualizarTurno(Turno turno)
        {
            _TurnoRepository.Actualizar(turno);
        }


        public void EliminarTurno(int id)
        {
            var turno = _TurnoRepository.ObtenerPorId(id);
            if(turno != null)
            {
                _TurnoRepository.Eliminar(turno);

            }
        }
    }
}
