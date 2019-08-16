using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketsystem.classes
{
    class Marca
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }

        public Marca() {
        }

        public Marca(int i, string n, string e, string t) {
            id = i;
            nome = n;
            endereco = e;
            telefone = t;
        }
    }
}
