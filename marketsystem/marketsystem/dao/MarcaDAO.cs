using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using marketsystem.util;
using marketsystem.classes;

namespace marketsystem.dao
{
    class MarcaDAO
    {
        public string SELECT_ALL = "SELECT * FROM marca ORDER BY id_marca ASC";
        public string SELECT = "";
        public string SELECT_ID = "";
        public string INSERT = "";
        public string UPDATE = "";
        public string DELETE = "";

        public List<Marca> Listar()
        {
            List<Marca> marcas = new List<Marca>();
            NpgsqlConnection conexao = null;

            try
            {
                conexao = new Conexao().CriarConexao();
                NpgsqlCommand cmd = new NpgsqlCommand(SELECT_ALL, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Marca marca = new Marca();
                    marca.Id = Int32.Parse(dr["id_marca"].ToString());
                    marca.Nome = dr["nome"].ToString();
                    marca.Cnpj = dr["cnpj"].ToString();
                    marca.Telefone = dr["telefone"].ToString();
                    marca.Endereco = dr["endereco"].ToString();

                    marcas.Add(marca);
                }
                return marcas;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao carregar Marcas " + ex.Message);
            }
            finally {
                conexao.Close();
            }
        }
    }
}
