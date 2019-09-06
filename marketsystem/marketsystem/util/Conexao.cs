using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace marketsystem.util
{
    class Conexao
    {
        public NpgsqlConnection CriarConexao()
        {
            //string de conexão
            string strConexao = string.Format("Server={0}; Port={1}; User Id={2}; Password={3}; Database={4}",
                                              "localhost", "5432", "postgres", "postgres", "dbmarketsystem");

            //abre conexão com o banco
            NpgsqlConnection conexao = new NpgsqlConnection(strConexao);
            conexao.Open();

            //retorna conexão;
            return conexao;
        }
    }
}
