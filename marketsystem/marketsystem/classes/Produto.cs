using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketsystem.classes
{
    class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Peso { get; set; }
        public int Quantidade { get; set; }
        public double Val_custo { get; set; }
        public double Val_venda { get; set; }
        public Marca Marca { get; set; }

        public Produto() {
        }

        public Produto(int i, string d, double p, int qt, double vc, double vv, Marca m) {
            Id = i;
            Descricao = d;
            Peso = p;
            Quantidade = qt;
            Val_custo = vc;
            Val_venda = vv;
            Marca = m;
        }
    }
}
