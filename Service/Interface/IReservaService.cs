using Data.Entidade;
using System;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IReservaService
    {
        public IEnumerable<ReservaCliente> ObterReservaClienteService(int cpf);

        public IEnumerable<ReservaCliente> InserirReservaService(int id_cliente, int id_veiculo, DateTime data_prev_devolucao);
    }
}
