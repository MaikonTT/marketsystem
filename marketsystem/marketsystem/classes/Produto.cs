using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketsystem.classes
{
    class Produto
    {
        public int id_produto { set; get; }
        public string desc { set; get; }
        public double peso { set; get; }
        public int quantidade { set; get; }
        public double valor_custo { set; get; }
        public double valor_venda { set; get; }
        public Marca marca;

        public Produto() {
        }

        public Produto(int i, string d, double p, int qt, double vc, double vv) {
            id_produto = i;
            desc = d;
            peso = p;
            quantidade = qt;
            valor_custo = vc;
            valor_venda = vv;
        }
    }
}
