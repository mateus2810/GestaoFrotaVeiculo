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

        public IEnumerable<Veiculo> InserirVeiculoRepository(Veiculo veiculo)
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

        public IEnumerable<Veiculo> ObterVeiculoPelaPlacaRepository(string numeroPlaca)
        {
            try
            {
                var parametros = new DynamicParameters();
                parametros.Add("@numeroPlaca","%"+ numeroPlaca + "%", DbType.String);


                const string sql = "SELECT * FROM veiculo where numero_placa LIKE @numeroPlaca";

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

        public IEnumerable<Veiculo> ObterVeiculoPeloModeloOuMarcaRepository(string filtroModeloOuFabricante)
        {
            try
            {
                var parametros = new DynamicParameters();
                parametros.Add("@filtroModeloOuFabricante", "%" + filtroModeloOuFabricante + "%", DbType.String);

                const string sql = "SELECT * FROM veiculo " +
                    "INNER JOIN fabricante ON fabricante.id_fabricante = veiculo.id_fabricante " +
                    "INNER JOIN modelo ON modelo.id_modelo = veiculo.id_modelo " +
                    "WHERE fabricante.nome_fabricante LIKE @filtroModeloOuFabricante " +
                    "OR modelo.nome_modelo LIKE @filtroModeloOuFabricante";

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
    }
}
