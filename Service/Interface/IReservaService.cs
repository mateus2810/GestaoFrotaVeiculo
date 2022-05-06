using Data.Entidade;
using System;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IReservaService
    {
        public IEnumerable<ReservaCliente> ObterReservaClienteService(int cpf);

        public IEnumerable<ReservaCliente> InserirReservaService(int id_cliente, int id_veiculo, DateTime data_prev_devolucao);

        public int AtualizarDataRetiradaService(DateTime data_retirada,int id_veiculo);
        public int AtualizarDataPrevisaDevolucaoService(DateTime data_prev_devolucao, int id_reserva);

        public IEnumerable<ReservaCliente> ObterVeiculoRetiradoService(DateTime data_inicio, DateTime data_fim);
    }
}
