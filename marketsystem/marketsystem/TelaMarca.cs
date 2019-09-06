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

        //Métodos de acesso a Classe e a DAO
        private void Listar()
        {
            MarcaDAO mDAO = new MarcaDAO();
            List<Marca> dataDAO = mDAO.Listar();
            dgvMarca.DataSource = dataDAO;
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
    }
}
