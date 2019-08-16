using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketsystem.classes
{
    class Funcionario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cargo { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string data_nasc { get; set; }

        public Funcionario() {
        }

        public Funcionario(int i, string n, string c, string e, string t, string d)
        {
            id = i;
            nome = n;
            cargo = c;
            endereco = e;
            telefone = t;
            data_nasc = d;
        }
    }
}
