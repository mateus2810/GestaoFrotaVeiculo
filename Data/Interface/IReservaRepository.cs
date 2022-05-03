﻿
using Data.Entidade;
using System;
using System.Collections.Generic;

namespace Data.Interface
{
    public interface IReservaRepository
    {
        public IEnumerable<ReservaCliente> ObterReservaClienteRepository(int cpf);
        public IEnumerable<ReservaCliente> InserirReservaRepository(int id_cliente, int id_veiculo, DateTime data_prev_devolucao);
    }
}
