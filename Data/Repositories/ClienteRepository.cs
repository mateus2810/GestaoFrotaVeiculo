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
    public class ClienteRepository : DbSession, IClienteRepository
    {
        public ClienteRepository(IConfiguration config) : base(config)
        {
        }

        public IEnumerable<Cliente> InserirClienteRepository(Cliente cliente)
        {
            try
            {
                var parametros = new DynamicParameters();
                parametros.Add("@nome", cliente?.nome, DbType.Int64);
                parametros.Add("@cpf", cliente.cpf, DbType.Int64);
                parametros.Add("@nascimento", cliente.nascimento, DbType.Date);
                parametros.Add("@numero_cnh", cliente.nome, DbType.String);
                parametros.Add("@endereco", cliente.endereco, DbType.String);

                const string sql = "" +
                    "INSERT INTO cliente " +
                    "(nome, cpf, nascimento, numero_cnh, endereco)" +
                    " VALUES (@nome, @cpf, @nascimento, @numero_cnh, @endereco)";


                ValidaConexao();

                var resultado = _conexao.Query<Cliente>(sql, parametros);

                Dispose();


                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception($"ERRO: {ex.Message}");
            }
        }

        public IEnumerable<Cliente> ObterTodosClientesRepository()
        {
            try
            {
                

                const string sql = "" +
                    "SELECT * FROM cliente";


                ValidaConexao();

                var resultado = _conexao.Query<Cliente>(sql);

                Dispose();


                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception($"ERRO: {ex.Message}");
            }
        }


        public IEnumerable<Cliente> ObterClientePeloCpfENomeRepository(string filtroNomeOuCpf)
        {
            try
            {
                var parametros = new DynamicParameters();
                parametros.Add("@filtro", filtroNomeOuCpf, DbType.String);

                const string sql = "SELECT * FROM cliente WHERE nome = @filtro";

                ValidaConexao();

                var resultado = _conexao.Query<Cliente>(sql);

                Dispose();


                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception($"ERRO: {ex.Message}");
            }
        }
    }
}
