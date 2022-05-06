
using Data.Output;
using System;
using System.Collections.Generic;

namespace Data.Interface
{
    public interface IReservaRepository
    {
        public IEnumerable<ReservaCliente> ObterReservaClienteRepository(int cpf);
        public IEnumerable<ReservaCliente> InserirReservaRepository(int id_cliente, int id_veiculo, DateTime data_prev_devolucao);

        public int AtualizarDataRetiradaRepository(DateTime data_retirada, int id_veiculo);

        public int AtualizarDataPrevisaDevolucaoRepository(DateTime data_prev_devolucao, int id_reserva);

        public IEnumerable<ReservaCliente> ObterVeiculoRetiradoService(DateTime data_inicio, DateTime data_fim);
    }
}
