using Data.Interface;
using Data.Output;
using Service.Interface;
using System;
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

        public IEnumerable<ReservaCliente> InserirReservaService(int id_cliente, int id_veiculo, DateTime data_prev_devolucao)
        {
            return _reservaRepository.InserirReservaRepository(id_cliente, id_veiculo, data_prev_devolucao);
        }

        public int AtualizarDataRetiradaService(DateTime data_retirada, int id_veiculo)
        {
            return _reservaRepository.AtualizarDataRetiradaRepository(data_retirada, id_veiculo);
        }

        public int AtualizarDataPrevisaDevolucaoService(DateTime data_prev_devolucao, int id_reserva)
        {
            return _reservaRepository.AtualizarDataPrevisaDevolucaoRepository(data_prev_devolucao, id_reserva);
        }

        public IEnumerable<ReservaCliente> ObterVeiculoRetiradoService(DateTime data_inicio, DateTime data_fim)
        {
            return _reservaRepository.ObterVeiculoRetiradoService(data_inicio, data_fim);
        }
    }
}
