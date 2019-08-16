using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketsystem.classes
{
    class Marca
    {
        public int id_marca { set; get; }
        public string nome { set; get; }
        public string endereco { set; get; }
        public string telefone { set; get; }

        public Marca() {
        }

        public Marca(int i, string n, string e, string t) {
            id_marca = i;
            nome = n;
            endereco = e;
            telefone = t;
        }
    }
}
