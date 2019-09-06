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
        public string SELECT = "SELECT * FROM funcionario WHERE nome ILIKE @item OR cargo ILIKE @item OR endereco ILIKE @item OR telefone ILIKE @item OR data_nasc ILIKE @item";
        public string SELECT_ID = "SELECT * FROM funcionario WHERE id_func = @id";
        public string INSERT = "INSERT INTO funcionario (nome, cargo, endereco, telefone, data_nasc) VALUES (@nome, @cargo, @endereco, @telefone, @data_nasc)";
        public string UPDATE = "UPDATE funcionario SET nome = @nome, cargo = @cargo, endereco = @endereco, telefone = @telefone, data_nasc = @data_nasc WHERE id_func = @id";
        public string DELETE = "DELETE FROM funcionario WHERE id_func = @id";

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
                throw new Exception("Listar " + e.Message);
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

        public List<Funcionario> Buscar(string item)
        {
            NpgsqlConnection conexao = null;
            List<Funcionario> func = new List<Funcionario>();

            try
            {
                conexao = new Conexao().CriarConexao();

                NpgsqlCommand cmd = new NpgsqlCommand(SELECT, conexao);
                cmd.Parameters.Add(new NpgsqlParameter("@item", item));

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
                throw new Exception("Não foi possível encontra funcionário " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public Funcionario Buscar_Id(int id)
        {
            NpgsqlConnection conexao = null;

            try
            {
                conexao = new Conexao().CriarConexao();

                Funcionario f = new Funcionario();

                NpgsqlCommand cmd = new NpgsqlCommand(SELECT_ID, conexao);
                cmd.Parameters.Add(new NpgsqlParameter("@id", id));

                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    f.Id = int.Parse(dr["id_func"].ToString());
                    f.Nome = dr["nome"].ToString();
                    f.Cargo = dr["cargo"].ToString();
                    f.Endereco = dr["endereco"].ToString();
                    f.Telefone = dr["telefone"].ToString();
                    f.Data_nasc = dr["data_nasc"].ToString();
                }
                return f;
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível encontra funcionário " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Alterar(Funcionario f)
        {
            NpgsqlConnection conexao = null;

            try
            {
                conexao = new Conexao().CriarConexao();

                NpgsqlCommand cmd = new NpgsqlCommand(UPDATE, conexao);

                cmd.Parameters.Add(new NpgsqlParameter("@nome", f.Nome));
                cmd.Parameters.Add(new NpgsqlParameter("@cargo", f.Cargo));
                cmd.Parameters.Add(new NpgsqlParameter("@endereco", f.Endereco));
                cmd.Parameters.Add(new NpgsqlParameter("@telefone", f.Telefone));
                cmd.Parameters.Add(new NpgsqlParameter("@data_nasc", f.Data_nasc));

                cmd.Parameters.Add(new NpgsqlParameter("@id", f.Id));

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Não foi possível alterar funcionario " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Excluir(int id)
        {
            NpgsqlConnection conexao = null;

            try
            {
                conexao = new Conexao().CriarConexao();

                NpgsqlCommand cmd = new NpgsqlCommand(DELETE, conexao);

                cmd.Parameters.Add(new NpgsqlParameter("@id", id));

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Falha ao excluír " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
