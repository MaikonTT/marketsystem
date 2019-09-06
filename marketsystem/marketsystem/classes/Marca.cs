using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketsystem.classes
{
    class Marca
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        public Marca() {
        }

        public Marca(int i, string n, string c, string t, string e) {
            Id = i;
            Nome = n;
            Cnpj = c;
            Telefone = t;
            Endereco = e;
        }
    }
}
