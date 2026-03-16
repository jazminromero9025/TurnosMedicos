using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnos.Domain.Interface;
using Turnos.Domain.Entities;

namespace Turnos.Application.Services
{
    public class PacienteService
    {

        private readonly IPacienteRepository _pacienteRepository;

        public PacienteService(IPacienteRepository pacienteRepository)
        {
            this._pacienteRepository = pacienteRepository;
        }

        public async Task CrearPaciente(Paciente paciente)
        {
            //aca podriamos poner validaciones de negocio
            await _pacienteRepository.AgregarPaciente(paciente);

        }

        public async Task<List<Paciente>> ObtenerTodos()
        {
            return await _pacienteRepository.ObtenerTodos();
        }

        public async Task<Paciente> ObtenerPorId(int id)
        {
            return await _pacienteRepository.ObtenerPorId(id);

        }

        public async Task EliminarPaciente(int id)
        {
            await _pacienteRepository.EliminarPaciente(id);
        }











    }
}
