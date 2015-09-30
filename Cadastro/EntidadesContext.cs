using Cadastro.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public class EntidadesContext : DbContext
    {
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
