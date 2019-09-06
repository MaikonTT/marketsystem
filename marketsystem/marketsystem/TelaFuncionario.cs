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

        //Solicita todos os dados no banco e atualiza datagrid
        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        //Efetua finalização de cadastro
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCadNome.Text) && !string.IsNullOrWhiteSpace(txtCadCargo.Text) && !string.IsNullOrWhiteSpace(txtCadTelefone.Text) && !string.IsNullOrWhiteSpace(txtCadEndereco.Text) && !string.IsNullOrWhiteSpace(txtCadData_nasc.Text))
            {
                Cadastrar();
            }
            else
            {
                string msg = "Preencha o campo:\n";

                if (string.IsNullOrWhiteSpace(txtCadNome.Text))
                {
                    msg += "\nNome!";
                }
                if (string.IsNullOrWhiteSpace(txtCadCargo.Text))
                {
                    msg += "\nCargo!";
                }
                if (string.IsNullOrWhiteSpace(txtCadTelefone.Text))
                {
                    msg += "\nTelefone";
                }
                if (string.IsNullOrWhiteSpace(txtCadEndereco.Text))
                {
                    msg += "\nEndereço";
                }
                if (string.IsNullOrWhiteSpace(txtCadData_nasc.Text))
                {
                    msg += "\nData de Nascimento";
                }
                MessageBox.Show(msg);
            }
        }

        //Abre formulário de Cadastro e esconde o de Alteração caso o mesmo esteja à mostra
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

        //Abre formulário de Alteração e esconde o de Cadastrar caso o mesmo esteja à mostra
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

        //Busca através dos dados digitados no campo de txtBuscar e atualiza datagrid
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                dgvFunc.DataSource = "";
            }
        }

        //Botão Excluir com confirmação
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAltNome.Text))
            {
                string func = txtAltNome.Text;
                if (MessageBox.Show($"Deseja excluir: {func}?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Excluir();
                }
            }
            else
            {
                MessageBox.Show("Selecione um funcionário primeiro...","Aviso", MessageBoxButtons.OK);
            }
        }

        //Busca por id da selação na datagrid e atualiza campos txtAlt...
        private void txtBuscaId_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscar.Text.Trim()))
            {
                int id = Int32.Parse(dgvFunc.CurrentRow.Cells[0].Value.ToString());
                Buscar_id(id);
            }
        }

        //Altera dados no banco da tabela funcionario
        private void btnAltEnviar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAltId.Text.Trim()))
            {
                Alterar();
            }
        }

        //Seleciona campo ID da linha selecionada
        private void dgvFunc_SelectionChanged(object sender, EventArgs e)
        {
            int id = Int32.Parse(dgvFunc.CurrentRow.Cells[0].Value.ToString());
            Buscar_id(id);
        }

        //Confirmação para fechamento do form
        private void TelaFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        //metodos da que instancia classe e DAO
        private void Cadastrar()
        {
            //adiciona o input nas variaveis
            string Nome = txtCadNome.Text;
            string Cargo = txtCadCargo.Text;
            string Endereco = txtCadEndereco.Text;
            string Telefone = txtCadTelefone.Text;
            string Data_nasc = txtCadData_nasc.Text;

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
                txtCadNome.Clear();
                txtCadCargo.Clear();
                txtCadEndereco.Clear();
                txtCadTelefone.Clear();
                txtCadData_nasc.Clear();

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
            string item = "%" + txtBuscar.Text.Trim() + "%";
            FuncionarioDAO fDAO = new FuncionarioDAO();
            List<Funcionario> dataDAO = fDAO.Buscar(item);
            dgvFunc.DataSource = dataDAO;
        }

        private void Buscar_id(int id)
        {
            FuncionarioDAO fDAO = new FuncionarioDAO();
            Funcionario f = fDAO.Buscar_Id(id);

            txtAltId.Text = f.Id.ToString();
            txtAltNome.Text = f.Nome;
            txtAltCargo.Text = f.Cargo;
            txtAltEndereco.Text = f.Endereco;
            txtAltTelefone.Text = f.Telefone;
            txtAltData_nasc.Text = f.Data_nasc;
        }

        private void Alterar()
        {
            int id = Convert.ToInt32(txtAltId.Text);
            string AltNome = txtAltNome.Text;
            string AltCargo = txtAltCargo.Text;
            string AltEndereco = txtAltEndereco.Text;
            string AltTelefone = txtAltTelefone.Text;
            string AltData_nasc = txtAltData_nasc.Text;

            Funcionario f = new Funcionario();
            FuncionarioDAO fDAO = new FuncionarioDAO();

            if (!string.IsNullOrWhiteSpace(txtAltNome.Text.Trim()))
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

                    txtAltId.Clear();

                    Listar();
                }
            }
        }

        private void Excluir()
        {
            if (!string.IsNullOrWhiteSpace(txtAltId.Text.Trim()))
            {
                try
                {
                    int id = Convert.ToInt32(txtAltId.Text);
                    FuncionarioDAO fDAO = new FuncionarioDAO();
                    fDAO.Excluir(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    txtAltNome.Clear();
                    txtAltCargo.Clear();
                    txtAltEndereco.Clear();
                    txtAltTelefone.Clear();
                    txtAltData_nasc.Clear();

                    txtAltId.Clear();

                    MessageBox.Show("Cadastro apagado com Sucesso", this.Text, MessageBoxButtons.OK);

                    Listar();
                }
            }
            else
            {
                MessageBox.Show("Digite um ID válido...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}