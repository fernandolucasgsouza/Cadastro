using Cadastro.Entidades;
using Cadastro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro.DAO
{
    public class ContatoDAO : IContato
    {
        private EntidadesContext contexto;

        public ContatoDAO()
        {
            this.contexto = new EntidadesContext();
        }

        public void Adiciona(Contato c)
        {
            contexto.Database.CreateIfNotExists();

            contexto.Contatos.Add(c);
            contexto.SaveChanges();
            contexto.Dispose();

            MessageBox.Show("Contato Salvo com Sucesso!","Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public Contato BuscaId(int id)
        {
            return contexto.Contatos.Find(id);
        }

        public void Remove(Contato c)
        {
            contexto.Contatos.Remove(c);
            contexto.SaveChanges();
            contexto.Dispose();
        }
        
        public void Altera(Contato c)
        {
            Contato contatoAltera =  contexto.Contatos.Where(contato => contato.Id == c.Id).First();
            contatoAltera.Nome = c.Nome;
            contatoAltera.DataNascimento = c.DataNascimento;
            contatoAltera.Email = c.Email;
            contatoAltera.Sexo = c.Sexo;
            contatoAltera.Cep = c.Cep;
            contatoAltera.Logradoouro = c.Logradoouro;
            contatoAltera.Numero = c.Numero;
            contatoAltera.Bairro = c.Bairro;
            contatoAltera.Municipio = c.Municipio;
            contatoAltera.Uf = c.Uf;

            contexto.SaveChanges();
            contexto.Dispose();
        }

        public IList<Contato> Lista()
        {
            var busca = from c in contexto.Contatos
                        orderby c.Nome
                        select c;

           return busca.ToList();
        }

        public IList<Contato> BuscaPorNome(string nome, string dataNascimento, string sexo, string email,
            string cep, string logradouro, string numero, string municipio, string bairro, string uf)
        {
            var busca = from c in contexto.Contatos select c;

            if (!string.IsNullOrEmpty(nome))
            {
                busca = from c in busca where c.Nome.Contains(nome) select c;
            }
            if (!string.IsNullOrEmpty(dataNascimento))
            {
                busca = from c in busca where c.DataNascimento.Contains(dataNascimento)select c;
            }
            if (!string.IsNullOrEmpty(sexo))
            {
                busca = from c in busca where c.Sexo.Contains(sexo) select c;
            }
            if (!string.IsNullOrEmpty(email))
            {
                busca = from c in busca where c.Email.Contains(email) select c;
            }
            if (!string.IsNullOrEmpty(cep))
            {
                busca = from c in busca where c.Cep.Contains(cep) select c;
            }
            if (!string.IsNullOrEmpty(logradouro))
            {
                busca = from c in busca where c.Logradoouro.Contains(logradouro) select c;
            }
            if (!string.IsNullOrEmpty(numero))
            {
                busca = from c in busca where c.Numero.Contains(numero) select c;
            }
            if (!string.IsNullOrEmpty(bairro))
            {
                busca = from c in busca where c.Bairro.Contains(bairro) select c;
            }
            if (!string.IsNullOrEmpty(municipio))
            {
                busca = from c in busca where c.Municipio.Contains(municipio) select c;
            }
            if (!string.IsNullOrEmpty(uf))
            {
                busca = from c in busca where c.Uf.Contains(uf) select c;
            }

            return busca.ToList();
        }

    }
}