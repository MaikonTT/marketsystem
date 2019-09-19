using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using marketsystem.classes;
using marketsystem.util;

namespace marketsystem.dao
{
    class ProdutoDAO
    {
        public string SELECT_ALL = "SELECT * FROM Produto_Marca";
        public string INSERT = "INSERT INTO produto " +
                               "(descricao, peso, quantidade, val_custo, val_venda, id_m) " +
                               "VALUES " +
                               "(@descricao, @peso, @quantidade, @val_custo, @val_venda," +
                               "(SELECT id_marca FROM marca WHERE nome ILIKE @marca))";
        public string UPDATE = "UPDATE ";
        public string DELETE = "DELETE produto WHERE id_prod = @id";

        public void Cadastrar(Produto prod)
        {
            NpgsqlConnection conexao = null;

            try
            {
                conexao = new Conexao().CriarConexao();
                NpgsqlCommand cmd = new NpgsqlCommand(INSERT, conexao);

                cmd.Parameters.Add(new NpgsqlParameter("@descricao", prod.Descricao));
                cmd.Parameters.Add(new NpgsqlParameter("@peso", prod.Peso));
                cmd.Parameters.Add(new NpgsqlParameter("@quantidade", prod.Quantidade));
                cmd.Parameters.Add(new NpgsqlParameter("@val_custo", prod.Val_custo));
                cmd.Parameters.Add(new NpgsqlParameter("@val_venda", prod.Val_venda));
                cmd.Parameters.Add(new NpgsqlParameter("@marca", prod.Marca));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível cadastrar produto " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public List<Produto> Listar()
        {
            NpgsqlConnection conexao = null;
            List<Produto> listaProdutos = new List<Produto>();


            try
            {
                conexao = new Conexao().CriarConexao();
                NpgsqlCommand cmd = new NpgsqlCommand(SELECT_ALL, conexao);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Produto p = new Produto();

                    p.Id = Int32.Parse(dr["id_prod"].ToString());
                    p.Descricao = dr["descricao"].ToString();
                    p.Peso = Double.Parse(dr["peso"].ToString());
                    p.Quantidade = Int32.Parse(dr["quantidade"].ToString());
                    p.Val_custo = Double.Parse(dr["val_custo"].ToString());
                    p.Val_venda = Double.Parse(dr["val_venda"].ToString());
                    p.Marca = dr["nome"].ToString();

                    listaProdutos.Add(p);
                }

                return listaProdutos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível listar produtos: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
