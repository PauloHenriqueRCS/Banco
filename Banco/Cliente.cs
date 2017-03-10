using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public  class Cliente
    {

        public Cliente() { }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public short Idade { get; set; }
        public string Sexo { get; set; }
        public string Nacionalidade { get; set; }
    }
}
