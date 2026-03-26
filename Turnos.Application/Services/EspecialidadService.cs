using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnos.Domain.Entities;
using Turnos.Domain.Interface;





namespace Turnos.Application.Services
{
    public class EspecialidadService : IEspecialidadService
    {
       
            private readonly IEspecialidadRepository _especialidadRepository;

            public EspecialidadService(IEspecialidadRepository especialidadRepository)
            {
                _especialidadRepository = especialidadRepository;
            }

            public async Task<IEnumerable<Especialidad>> ObtenerTodas()
            {
                return await _especialidadRepository.ObtenerTodas();
            }

            public async Task<Especialidad?> ObtenerPorId(int id)
            {
                return await _especialidadRepository.ObtenerPorId(id);
            }

            public async Task CrearEspecialidad(Especialidad especialidad)
            {
                await _especialidadRepository.AgregarEspecialidad(especialidad);
            }

            public async Task EliminarEspecialidad(int id)
            {
                await _especialidadRepository.Eliminar(id);
            }


        public async Task ActualizarEspecialidad(int id, Especialidad especialidad)
        {
            var existente = await _especialidadRepository.ObtenerPorId(id);

            if (existente != null)
            {
                existente.Nombre = especialidad.Nombre;
                await _especialidadRepository.Actualizar(existente);
            }
        }


    }






 }

