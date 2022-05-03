using Data.Entidade;
using Data.Interface;
using Service.Interface;
using System.Collections.Generic;

namespace Service.Service
{
    public class ReservaService : IReservaService
    {
        private readonly IReservaRepository _reservaRepository;
        public ReservaService(IReservaRepository reservaRepository)
        {
            _reservaRepository = reservaRepository;
        }
        public IEnumerable<ReservaCliente> ObterReservaClienteService(int cpf)
        {
            return _reservaRepository.ObterReservaClienteRepository(cpf);
        }

        //public IEnumerable<ReservaCliente> InserirReservaService(int cpf);
        //{
        //    return _reservaService.ObterReservaCliente(cpf);
        //}
    }
}
