using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turnos.Domain.Entities;
using Turnos.Domain.Interface;



namespace Turnos.Application.Services
{
    public class MedicoService : IMedicoService
    {
        private readonly IMedicoRepository _medicoRepository;


        public MedicoService(IMedicoRepository medicoRepository)
        {
            this._medicoRepository = medicoRepository;

        }


        public async Task CrearMedico (Medico medico)
        {
            //aca podriamos poner validaciones de negocio
            await _medicoRepository.AgregarMedico(medico);
        }


        public async Task <List<Medico>> ObtenerTodos()
        {
            return await _medicoRepository.ObtenerTodos();
        }

        public async Task <Medico> ObtenerPorId(int id)
        {
            return await _medicoRepository.ObtenerPorId(id);
        }


        public async Task EliminarMedico(int id)
        {
            await _medicoRepository.EliminarMedico(id);
        }


        public async Task ActualizarMedico(Medico medico)
        {
            await _medicoRepository.ActualizarMedico(medico);
        }




    }
}
