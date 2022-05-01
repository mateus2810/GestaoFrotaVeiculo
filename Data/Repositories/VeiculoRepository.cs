using Dapper;
using Data.Entidade;
using Data.Interfaces;
using Data.Repositories.Base;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;

namespace Data
{
    public class VeiculoRepository : DbSession, IVeiculoRepository
    {
        public VeiculoRepository(IConfiguration config) : base(config)
        {
        }

        public IEnumerable<Veiculo> InserirVeiculo(Veiculo veiculo)
        {
            try
            {
                var parametros = new DynamicParameters();
                parametros.Add("@id_cliente", veiculo?.id_cliente, DbType.Int64);
                parametros.Add("@id_fabricante", veiculo.id_fabricante, DbType.Int64);
                parametros.Add("@numero_placa", veiculo.numero_placa, DbType.Date);
                parametros.Add("@chassi", veiculo.chassi, DbType.String);


                const string sql = "" +
                    "INSERT INTO veiculo " +
                    "(id_cliente, id_fabricante, numero_placa, chassi)" +
                    " VALUES (@id_cliente, @id_fabricante, @numero_placa, @chassi)";


                ValidaConexao();

                var resultado = _conexao.Query<Veiculo>(sql, parametros);

                Dispose();


                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception($"ERRO: {ex.Message}");
            }
        }

        public IEnumerable<Ator> Teste()
        {
            try
            {

                const string sql = "select * from ator";


                ValidaConexao();

                var resultado = _conexao.Query<Ator>(sql);

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
