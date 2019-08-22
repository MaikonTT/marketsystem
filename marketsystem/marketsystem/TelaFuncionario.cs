using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using marketsystem.dao;
using marketsystem.classes;

namespace marketsystem
{
    public partial class TelaFuncionario : Form
    {
        public TelaFuncionario()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Cadastrar();
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
            if (txtBuscar.Text == "" || txtBuscar.Text == " ")
            {
                dgvFunc.DataSource = "";
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void txtBuscaId_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaId.Text != "" && txtBuscaId.Text != " ")
            {
                Buscar_id();
            }
        }

        private void btnAltEnviar_Click(object sender, EventArgs e)
        {
            if (txtBuscaId.Text != "" && txtBuscaId.Text != " ")
            {
                Alterar();
            }
        }

        //metodos da DAO
        private void Cadastrar()
        {
            //adiciona o input nas variaveis
            string Nome = txtNome.Text;
            string Cargo = txtCargo.Text;
            string Endereco = txtEndereco.Text;
            string Telefone = txtTelefone.Text;
            string Data_nasc = txtData_nasc.Text;

            //instancia modelo Funcionario
            Funcionario f = new Funcionario();
            FuncionarioDAO fDAO = new FuncionarioDAO();

            try
            {
                //atribui texto do input nos atributos do modelo Funcionario
                f.Nome = Nome;
                f.Cargo = Cargo;
                f.Endereco = Endereco;
                f.Telefone = Telefone;
                f.Data_nasc = Data_nasc;

                fDAO.Cadastrar(f);

                MessageBox.Show("Cadastrado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível cadastrar funcionario " + ex.Message);
            }
            finally
            {
                txtNome.Clear();
                txtCargo.Clear();
                txtEndereco.Clear();
                txtTelefone.Clear();
                txtData_nasc.Clear();

                Listar();
            }
        }

        private void Listar()
        {
            FuncionarioDAO fDAO = new FuncionarioDAO();
            List<Funcionario> dataDAO = fDAO.Listar();
            dgvFunc.DataSource = dataDAO;
        }

        private void Buscar()
        {
            FuncionarioDAO fDAO = new FuncionarioDAO();
            Funcionario f = new Funcionario();
            string item = txtBuscar.Text;
            item = "%" + item + "%";

            List<Funcionario> dataDAO = fDAO.Buscar(item);
            dgvFunc.DataSource = dataDAO;
        }

        private void Buscar_id()
        {
            int id = Convert.ToInt32(txtBuscaId.Text);

            FuncionarioDAO fDAO = new FuncionarioDAO();
            Funcionario f = fDAO.Buscar_Id(id);

            txtAltNome.Text = f.Nome;
            txtAltCargo.Text = f.Cargo;
            txtAltEndereco.Text = f.Endereco;
            txtAltTelefone.Text = f.Telefone;
            txtAltData_nasc.Text = f.Data_nasc;
        }

        private void Alterar()
        {
            int id = Convert.ToInt32(txtBuscaId.Text);
            string AltNome = txtAltNome.Text;
            string AltCargo = txtAltCargo.Text;
            string AltEndereco = txtAltEndereco.Text;
            string AltTelefone = txtAltTelefone.Text;
            string AltData_nasc = txtAltData_nasc.Text;

            Funcionario f = new Funcionario();
            FuncionarioDAO fDAO = new FuncionarioDAO();

            if (txtAltNome.Text != "")
            {
                try
                {
                    f.Id = id;
                    f.Nome = AltNome;
                    f.Cargo = AltCargo;
                    f.Endereco = AltEndereco;
                    f.Telefone = AltTelefone;
                    f.Data_nasc = AltData_nasc;

                    fDAO.Alterar(f);

                    MessageBox.Show("Alterado com Sucesso!");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Não foi possível alterar funcionário " + e.Message);
                }
                finally
                {
                    txtAltNome.Clear();
                    txtAltCargo.Clear();
                    txtAltEndereco.Clear();
                    txtAltTelefone.Clear();
                    txtAltData_nasc.Clear();

                    txtBuscaId.Clear();

                    Listar();
                }
            }
        }

        private void Excluir()
        {
            int id = Convert.ToInt32(txtBuscaId.Text);

            try
            {
                FuncionarioDAO fDAO = new FuncionarioDAO();
                fDAO.Excluir(id);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                txtAltNome.Clear();
                txtAltCargo.Clear();
                txtAltEndereco.Clear();
                txtAltTelefone.Clear();
                txtAltData_nasc.Clear();

                txtBuscaId.Clear();

                Listar();
            }
        }
    }
}
