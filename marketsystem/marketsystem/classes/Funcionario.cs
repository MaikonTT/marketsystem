using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketsystem.classes
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Data_nasc { get; set; }

        public Funcionario() {
        }

        public Funcionario(int i, string n, string c, string e, string t, string d)
        {
            Id = i;
            Nome = n;
            Cargo = c;
            Endereco = e;
            Telefone = t;
            Data_nasc = d;
        }
    }
}
