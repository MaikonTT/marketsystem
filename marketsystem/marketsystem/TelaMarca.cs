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

        private void Listar()
        {
            MarcaDAO mDAO = new MarcaDAO();
            List<Marca> dataDAO = mDAO.Listar();
            dgvMarca.DataSource = dataDAO;
        }
    }
}
