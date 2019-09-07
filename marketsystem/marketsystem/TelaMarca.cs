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
                txtAltId.Clear();
                txtAltNome.Clear();
                txtAltCnpj.Clear();
                txtAltTelefone.Clear();
                txtAltEndereco.Clear();
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
            string item = "%" + txtBuscar.Text + "%";
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
                if (dgvMarca.DataSource != null)
                {
                    Listar();
                }
            }
            else
            {
                string msg = "Preencha o campo:\n";

                if (string.IsNullOrWhiteSpace(txtCadNome.Text))
                {
                    msg += "\nNome";
                }
                if (string.IsNullOrWhiteSpace(txtCadCnpj.Text))
                {
                    msg += "\nCNPJ";
                }
                if (string.IsNullOrWhiteSpace(txtCadTelefone.Text))
                {
                    msg += "\nTelefone";
                }
                if (string.IsNullOrWhiteSpace(txtCadEndereco.Text))
                {
                    msg += "\nEndereço";
                }
                MessageBox.Show(msg, "Aviso");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAltNome.Text))
            {
                string marca = txtAltNome.Text;
                if (MessageBox.Show($"Deseja excluir: {marca}?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Excluir();
                    Listar();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma marca primeiro...", "Aviso", MessageBoxButtons.OK);
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
            finally
            {
                txtCadNome.Clear();
                txtCadCnpj.Clear();
                txtCadTelefone.Clear();
                txtCadEndereco.Clear();
            }
        }

        private void Alterar() { }

        private void Excluir()
        {
            if (!string.IsNullOrWhiteSpace(txtAltId.Text))
            {
                try
                {
                    int id = Convert.ToInt32(txtAltId.Text);
                    MarcaDAO mDAO = new MarcaDAO();
                    mDAO.Excluir(id);

                    MessageBox.Show("Cadastro apagado com Sucesso", this.Text, MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível apagar marca " + ex.Message);
                }
                finally
                {
                    txtAltNome.Clear();
                    txtAltCnpj.Clear();
                    txtAltTelefone.Clear();
                    txtAltEndereco.Clear();

                    txtAltId.Clear();                    
                }
            }
            else
            {
                MessageBox.Show("Digite um ID válido...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
