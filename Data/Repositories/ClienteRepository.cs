using Dapper;
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
                parametros.Add("@nome", cliente?.nome, DbType.String);
                parametros.Add("@cpf", cliente.cpf, DbType.String);
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


        public IEnumerable<Cliente> ObterClientePeloCpfENomeRepository(string filtroCpfOuNome)
        {
            try
            {
                var parametros = new DynamicParameters();
                parametros.Add("@filtro", "%" + filtroCpfOuNome + "%", DbType.String);


                const string sql = "SELECT * FROM cliente where nome LIKE @filtro OR cpf LIKE @filtro";

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

        public int AtualizarEnderecoClienteRepository(int cpf, string endereco)
        {
            try
            {
                var parametros = new DynamicParameters();
                parametros.Add("@cpf", cpf, DbType.String);
                parametros.Add("@endereco", endereco, DbType.String);

                const string sql = "UPDATE cliente SET endereco = @endereco WHERE cpf = @cpf";


                ValidaConexao();

                var resultado = _conexao.Execute(sql, parametros);

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
