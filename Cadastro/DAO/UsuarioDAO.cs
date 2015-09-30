using Cadastro.Interfaces;
using Cadastro.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cadastro.DAO
{
    public class UsuarioDAO : IUsuario
    {
        EntidadesContext contexto;

        public UsuarioDAO()
        {
            this.contexto = new EntidadesContext();
        }
        public void Adiciona(Usuario u)
        {
            contexto.Database.CreateIfNotExists();

            contexto.Usuarios.Add(u);
            contexto.SaveChanges();
            contexto.Dispose();

            MessageBox.Show("Usuário Salvo com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public Usuario BuscaId(int id)
        {
            return contexto.Usuarios.Find(id);
        }

        public void Remove(Usuario u)
        {
            contexto.Usuarios.Remove(u);
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public IList<Usuario> Listar()
        {
            var busca = from u in contexto.Usuarios
                        orderby u.Nome
                        select u;

            return busca.ToList();

        }

        public IList<Usuario> BuscaPorNome(string nome)
        {
            var busca = from u in contexto.Usuarios select u;

            if (!string.IsNullOrEmpty(nome))
            {
                busca = from u in busca where u.Nome.Contains(nome) select u;
            }

            return busca.ToList();
        }
    }
}
