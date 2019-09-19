using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using marketsystem.classes;
using marketsystem.dao;

namespace marketsystem
{
    public partial class TelaProduto : Form
    {
        public TelaProduto()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //mostra campo formulario
            gbCadastrar.Show();

            //carrega combobox de marca
            var listaMarcas = CarregarCombo();

            listaMarcas.Sort(delegate (Marca m1, Marca m2)
            {
                return m1.Nome.CompareTo(m2.Nome);
            });

            listaMarcas.ForEach(delegate (Marca m)
           {
               cbCadMarca.Items.Add(m.Nome);
           });
        }

        private void btnCadEnviar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCadDescri.Text) && !string.IsNullOrWhiteSpace(txtCadPeso.Text) && !string.IsNullOrWhiteSpace(txtCadQuant.Text) && !string.IsNullOrWhiteSpace(txtCadValCust.Text) && !string.IsNullOrWhiteSpace(txtCadValVend.Text))
            {
                Cadastrar();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Metodos de acesso a classe e a DAO
        private void Cadastrar()
        {
            try
            {
                ProdutoDAO pDAO = new ProdutoDAO();
                Produto prod = new Produto();

                prod.Descricao = txtCadDescri.Text;
                prod.Peso = Double.Parse(txtCadPeso.Text);
                prod.Quantidade = Int32.Parse(txtCadQuant.Text);
                prod.Val_custo = Double.Parse(txtCadValCust.Text);
                prod.Val_venda = Double.Parse(txtCadValVend.Text);
                prod.Marca = "%" + cbCadMarca.SelectedItem + "%";
                
                pDAO.Cadastrar(prod);

                MessageBox.Show("Produto cadastrado!", "Sucesso", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível completar o cadastro: " + ex.Message);
            }
            finally {
                txtCadDescri.Clear();
                txtCadPeso.Clear();
                txtCadQuant.Clear();
                txtCadValCust.Clear();
                txtCadValVend.Clear();
                cbCadMarca.Text = "";
            }
        }

        private void Listar() {
            ProdutoDAO pDAO = new ProdutoDAO();
            List<Produto> listaProduto = pDAO.Listar();
            dgvProd.DataSource = listaProduto;
        }

        private void Alterar() { }

        private void Excluir() { }

        private List<Marca> CarregarCombo()
        {
            //string que indica como será ordenado a lista
            MarcaDAO mDAO = new MarcaDAO();
            List<Marca> listaMarcas = mDAO.Listar();
            return listaMarcas;
        }
    }
}
