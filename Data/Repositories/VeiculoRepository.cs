using Dapper;
using Data.Entidade;
using Data.Interfaces;
using Data.Repositories.Base;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace Data
{
    public class VeiculoRepository : DbSession, IVeiculoRepository
    {
        public VeiculoRepository(IConfiguration config) : base(config)
        {
        }



        //public VeiculoRepository(DbSession dbSession)
        //{
        //    _db = dbSession;
        //}


        public IEnumerable<Ator> Teste()
        {
            try
            {
                const string sql = "SELECT * FROM ator ";

                ValidaConexao();

                var resultado = _conexao.Query<Ator>(sql);

                Dispose();


                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception($"ERRO: {ex.Message}");
            }

            //    const string query = "SELECT sexo FROM ator";

            //_db.ValidaConexao();

            //    var tarefas = conexao.Query<Ator>(query);
            //    return (Ator)tarefas;

        }
    }
}
