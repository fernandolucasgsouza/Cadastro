using Cadastro.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Interfaces
{
    public interface IContato
    {
        void Adiciona(Contato c);
        Contato BuscaId(int id);
        void Remove(Contato c);
        void Altera(Contato c);
        IList<Contato> Lista();
        IList<Contato> BuscaPorNome(string nome, string dataNascimento, string sexo, string email,
            string cep, string logradouro, string numero, string municipio, string bairro, string uf);
    }
}
