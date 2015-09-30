using Cadastro.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Interfaces
{
     public interface IUsuario
    {
        void Adiciona(Usuario u);
        Usuario BuscaId(int id);
        void Remove(Usuario u);
        IList<Usuario> Listar();
        IList<Usuario> BuscaPorNome(string nome);
    }
}
