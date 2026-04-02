using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnos.Domain.Entities;
using Turnos.Domain.Interface;

namespace Turnos.Application.Services
{
    public class TurnoService :ITurnoService
    {
        private readonly ITurnoRepository _TurnoRepository;

        public TurnoService(ITurnoRepository turnoRepository)
        {
            this._TurnoRepository = turnoRepository;
        }

        public void CrearTurno(Turno turno)
        {
            var turnos = _TurnoRepository.Lista();

            bool existe = turnos.Any(t =>
                t.MedicoId == turno.MedicoId &&
                t.FechaHora == turno.FechaHora);

            if (existe)
                throw new Exception("El turno ya existe para ese médico en ese horario");

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

            if (turno == null)
                throw new Exception("Turno no encontrado");

            _TurnoRepository.Eliminar(turno);
        }
    }
}
