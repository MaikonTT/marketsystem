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

        //Metodos de acesso a classe e a DAO
        private void Cadastrar()
        {
            ProdutoDAO pDAO = new ProdutoDAO();
            Produto prod = new Produto();

            prod.Descricao = txtCadDescri.Text;
            //prod.Marca = cbCadMarca.SelectedValue;

            pDAO.Cadastrar(prod);
        }

        private void Listar() { }

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
