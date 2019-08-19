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
                txtData_nasc.Clear();
                txtTelefone.Clear();
                txtEndereco.Clear();

                Listar();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (gbFormularioCad.Visible == false)
            {
                gbFormularioCad.Show();
            }
            else
            {
                gbFormularioCad.Hide();
            }
        }

        private void Listar()
        {
            FuncionarioDAO fDAO = new FuncionarioDAO();
            Funcionario f = new Funcionario();
            List<Funcionario> dataDAO = fDAO.Listar();
            dgvFunc.DataSource = dataDAO;
        }

    }
}
