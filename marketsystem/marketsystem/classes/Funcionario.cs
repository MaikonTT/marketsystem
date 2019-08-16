using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketsystem.classes
{
    class Funcionario
    {
        public int id_func { set; get; }
        public string nome { set; get; }
        public string cargo { set; get; }
        public string endereco { set; get; }
        public string telefone { set; get; }
        public string data_nascimento { set; get }

        public Funcionario() {
        }

        public Funcionario(int i, string n, string c, string e, string t, string d)
        {
            id_func = i;
            nome = n;
            cargo = c;
            endereco = e;
            telefone = t;
            data_nascimento = d;
        }
    }
}
