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
    public partial class TelaMarca : Form
    {
        public TelaMarca()
        {
            InitializeComponent();
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (gbCadastrar.Visible == false)
            {
                gbCadastrar.Show();
                gbAlterar.Hide();
            }
            else
            {
                gbCadastrar.Hide();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (gbAlterar.Visible == false)
            {
                gbAlterar.Show();
                gbCadastrar.Hide();
            }
            else
            {
                gbAlterar.Hide();
            }
        }

        private void dgvMarca_SelectionChanged(object sender, EventArgs e)
        {
            int id = Int32.Parse(dgvMarca.CurrentRow.Cells[0].Value.ToString());
            Buscar_id(id);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                dgvMarca.DataSource = "";
            }
        }

        //Métodos de acesso a Classe e a DAO
        private void Listar()
        {
            MarcaDAO mDAO = new MarcaDAO();
            List<Marca> listaMarca = mDAO.Listar();
            dgvMarca.DataSource = listaMarca;
        }

        private void Buscar()
        {
            string item = "%" + txtBuscar.Text.Trim() + "%";
            MarcaDAO mDAO = new MarcaDAO();
            List<Marca> listaMarca = mDAO.Buscar(item);
            dgvMarca.DataSource = listaMarca;
        }

        private void Buscar_id(int id)
        {
            MarcaDAO mDAO = new MarcaDAO();
            Marca marca = mDAO.Buscar_Id(id);

            txtAltId.Text = marca.Id.ToString();
            txtAltNome.Text = marca.Nome;
            txtAltCnpj.Text = marca.Cnpj;
            txtAltTelefone.Text = marca.Telefone;
            txtAltEndereco.Text = marca.Endereco;
        }

        private void btnCadEnviar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCadNome.Text) && !string.IsNullOrWhiteSpace(txtCadCnpj.Text) && !string.IsNullOrWhiteSpace(txtCadTelefone.Text) && !string.IsNullOrWhiteSpace(txtCadEndereco.Text))
            {
                Cadastrar();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtCadNome.Text))
                {
                    MessageBox.Show("Preencha o campo Nome!");
                }
                if (string.IsNullOrWhiteSpace(txtCadCnpj.Text))
                {
                    MessageBox.Show("Preencha o campo CNPJ!");
                }
                if (string.IsNullOrWhiteSpace(txtCadTelefone.Text))
                {
                    MessageBox.Show("Preencha o campo Telefone!");
                }
                if (string.IsNullOrWhiteSpace(txtCadEndereco.Text))
                {
                    MessageBox.Show("Preencha o campo Endereço!");
                }
            }
        }

        private void Cadastrar()
        {

            //Cadastro sendo feito sem uso de variáveis iniciadas antes
            Marca marca = new Marca();
            MarcaDAO mDAO = new MarcaDAO();

            try
            {
                marca.Nome = txtCadNome.Text;
                marca.Cnpj = txtCadCnpj.Text;
                marca.Telefone = txtCadTelefone.Text;
                marca.Endereco = txtCadEndereco.Text;

                mDAO.Cadastrar(marca);

                MessageBox.Show("Marca Cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar o cadastro " + ex.Message);
            }
            finally { }


        }

        private void Alterar() { }

        private void Excluir() { }
    }
}
