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
        public string SELECT_ALL = "SELECT * FROM marca";
        public string SELECT = "SELECT * FROM marca WHERE nome ILIKE @item OR cnpj ILIKE @item OR telefone ILIKE @item OR endereco ILIKE @item";
        public string SELECT_ID = "SELECT * FROM marca WHERE id_marca = @id";
        public string INSERT = "INSERT INTO marca (nome, cnpj, telefone, endereco) VALUES (@nome, @cnpj, @telefone, @endereco)";
        public string UPDATE = "UPDATE marca SET nome = @nome, cnpj = @cnpj, telefone = @telefone, endereco = @endereco WHERE id_marca = @id";
        public string DELETE = "DELETE FROM marca where id_marca = @id";

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
            finally
            {
                conexao.Close();
            }
        }

        public List<Marca> Buscar(string item)
        {
            NpgsqlConnection conexao = null;
            List<Marca> listaMarcas = new List<Marca>();

            try
            {
                conexao = new Conexao().CriarConexao();
                NpgsqlCommand cmd = new NpgsqlCommand(SELECT, conexao);
                cmd.Parameters.Add(new NpgsqlParameter("@item", item));

                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Marca marca = new Marca();
                    marca.Id = int.Parse(dr["id_marca"].ToString());
                    marca.Nome = dr["nome"].ToString();
                    marca.Cnpj = dr["cnpj"].ToString();
                    marca.Telefone = dr["telefone"].ToString();
                    marca.Endereco = dr["endereco"].ToString();
                    listaMarcas.Add(marca);
                }
                return listaMarcas;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível encontrar Marca " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public Marca Buscar_Id(int id)
        {
            Marca marca = new Marca();

            NpgsqlConnection conexao = null;

            try
            {
                conexao = new Conexao().CriarConexao();
                NpgsqlCommand cmd = new NpgsqlCommand(SELECT_ID, conexao);
                cmd.Parameters.Add(new NpgsqlParameter("@id", id));

                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    marca.Id = Int32.Parse(dr["id_marca"].ToString());
                    marca.Nome = dr["nome"].ToString();
                    marca.Cnpj = dr["cnpj"].ToString();
                    marca.Telefone = dr["telefone"].ToString();
                    marca.Endereco = dr["endereco"].ToString();
                }
                return marca;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar Id " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Cadastrar(Marca marca)
        {
            NpgsqlConnection conexao = null;

            try
            {
                conexao = new Conexao().CriarConexao();
                NpgsqlCommand cmd = new NpgsqlCommand(INSERT, conexao);

                cmd.Parameters.Add(new NpgsqlParameter("@nome", marca.Nome));
                cmd.Parameters.Add(new NpgsqlParameter("@cnpj", marca.Cnpj));
                cmd.Parameters.Add(new NpgsqlParameter("@telefone", marca.Telefone));
                cmd.Parameters.Add(new NpgsqlParameter("@endereco", marca.Endereco));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível cadastrar " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Alterar(Marca marca)
        {
            NpgsqlConnection conexao = null;

            try
            {
                conexao = new Conexao().CriarConexao();
                NpgsqlCommand cmd = new NpgsqlCommand(INSERT, conexao);

                cmd.Parameters.Add(new NpgsqlParameter("@nome", marca.Nome));
                cmd.Parameters.Add(new NpgsqlParameter("@cnpj", marca.Cnpj));
                cmd.Parameters.Add(new NpgsqlParameter("@telefone", marca.Telefone));
                cmd.Parameters.Add(new NpgsqlParameter("@endereco", marca.Endereco));

                cmd.Parameters.Add(new NpgsqlParameter("@id", marca.Id));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível alterar " + ex.Message);
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
            catch (Exception ex)
            {
                throw new Exception("Falha ao excluir marca " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
