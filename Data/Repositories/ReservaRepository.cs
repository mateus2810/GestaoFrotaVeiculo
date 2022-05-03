﻿using Dapper;
using Data.Entidade;
using Data.Interface;
using Data.Repositories.Base;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;

namespace Data.Repositories
{
    public class ReservaRepository : DbSession, IReservaRepository
    {
        public ReservaRepository(IConfiguration config) : base(config)
        {
        }

        public IEnumerable<ReservaCliente> ObterReservaClienteRepository(int cpf)
        {
            try
            {
                var parametros = new DynamicParameters();
                parametros.Add("@cpf", "%" + cpf + "%", DbType.Int64);

                const string sql = @"SELECT cliente.nome as nome_cliente, cliente.cpf, fabricante.nome_fabricante, 
                            modelo.nome_modelo, reserva.data_retirada, reserva.data_prev_devolucao, 
                            reserva.data_devolucao, veiculo.numero_placa FROM cliente
                            INNER JOIN reserva ON reserva.id_cliente = cliente.id_cliente
                            INNER JOIN veiculo ON veiculo.id_veiculo = reserva.id_veiculo
                            INNER JOIN modelo ON modelo.id_modelo = veiculo.id_modelo
                            INNER JOIN fabricante ON fabricante.id_fabricante = modelo.id_fabricante
                            WHERE cliente.cpf LIKE @cpf";


                ValidaConexao();

                var resultado = _conexao.Query<ReservaCliente>(sql, parametros);

                Dispose();


                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception($"ERRO: {ex.Message}");
            }
        }
        //INSERIR
        //insert into reserva (id_cliente, id_veiculo, data_retirada, data_prev_devolucao, data_devolucao) values (28, 9, '2022/05/02', '2022/05/03', null)
    }
}
