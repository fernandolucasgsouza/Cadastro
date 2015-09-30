using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Entidades
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Logradoouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }

    }

}
