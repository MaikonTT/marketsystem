using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketsystem.classes
{
    class Produto
    {
        public int id { get; set; }
        public string desc { get; set; }
        public double peso { get; set; }
        public int quantidade { get; set; }
        public double valor_custo { get; set; }
        public double valor_venda { get; set; }
        public Marca marca;

        public Produto() {
        }

        public Produto(int i, string d, double p, int qt, double vc, double vv) {
            id = i;
            desc = d;
            peso = p;
            quantidade = qt;
            valor_custo = vc;
            valor_venda = vv;
        }
    }
}
