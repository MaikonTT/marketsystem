using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using marketsystem.classes;
using Npgsql;
using marketsystem.util;


namespace marketsystem.dao
{
    class FuncionarioDAO
    {
        public string SELECT_ALL = "SELECT * FROM funcionario ORDER BY id_func ASC";
        public string INSERT = "INSERT INTO funcionario (nome, cargo, endereco, telefone, data_nasc) VALUES (@nome, @cargo, @endereco, @telefone, @data_nasc)";
        
        public List<Funcionario> Listar()
        {
            //abre conexao
            NpgsqlConnection conexao = null;

            try
            {
                List<Funcionario> func = new List<Funcionario>();

                //cria conexao
                conexao = new Conexao().CriarConexao();

                //executa comando sql
                NpgsqlCommand cmd = new NpgsqlCommand(SELECT_ALL, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Funcionario f = new Funcionario();
                    f.Id = int.Parse(dr["id_func"].ToString());
                    f.Nome = dr["nome"].ToString();
                    f.Cargo = dr["cargo"].ToString();
                    f.Endereco = dr["endereco"].ToString();
                    f.Telefone = dr["telefone"].ToString();
                    f.Data_nasc = dr["data_nasc"].ToString();
                    func.Add(f);
                }
                return func;
            }
            catch (Exception e)
            {
                //trata o erro
                throw new Exception("Erro ao cadastrar " + e.Message);
            }
            finally
            {
                //finaliza conexao
                conexao.Close();
            }
        }

        public void Cadastrar(Funcionario f)
        {
            NpgsqlConnection conexao = null;

            try
            {
                conexao = new Conexao().CriarConexao();

                NpgsqlCommand cmd = new NpgsqlCommand(INSERT, conexao);

                cmd.Parameters.Add(new NpgsqlParameter("@nome", f.Nome));
                cmd.Parameters.Add(new NpgsqlParameter("@cargo", f.Cargo));
                cmd.Parameters.Add(new NpgsqlParameter("@endereco", f.Endereco));
                cmd.Parameters.Add(new NpgsqlParameter("@telefone", f.Telefone));
                cmd.Parameters.Add(new NpgsqlParameter("@data_nasc", f.Data_nasc));

                cmd.ExecuteNonQuery();                
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível cadastrar funcionario " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        
    }
}
