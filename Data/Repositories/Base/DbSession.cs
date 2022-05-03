using Microsoft.Extensions.Configuration;
using MySqlConnector;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Data.Repositories.Base
{
    public class DbSession: IDisposable
    {
        protected readonly MySqlConnection _conexao;
        public DbSession(IConfiguration config)
        {
            try
            {
                _conexao = new MySqlConnection(config.GetConnectionString("DefaultConnection"));
            }
            catch (Exception ex)
            {
                throw new Exception($"ERRO: {ex.Message}");
            }
        }

        public void ValidaConexao()
        {

            if (_conexao.State != ConnectionState.Open)
                _conexao.Open();
        }

        public void Dispose()
        {
            try
            {
                if (_conexao.State != ConnectionState.Open)
                    return;

                _conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"ERROR: {ex.Message}");
            }
        }


        //public IDbConnection Connection { get; }
        //protected readonly MySqlConnection conexao;
        //public DbSession(IConfiguration configuration)
        //{
        //    //conexão com mysql 
        //    conexao = new MySqlConnection(configuration.GetConnectionString("DefaultConnection"));

        //    //Connection = new SqlConnection(configuration
        //    //         .GetConnectionString("DefaultConnection"));
        //}

        //public void ValidaConexao()
        //{

        //    if (conexao.State != ConnectionState.Open)
        //        conexao.Open();
        //}
        //public void Dispose() => Connection?.Dispose();
    }
}
