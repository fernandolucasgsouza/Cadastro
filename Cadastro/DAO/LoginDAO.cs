using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro.DAO
{
    public class LoginDAO
    {
        EntidadesContext contexto;

        public LoginDAO()
        {
            contexto = new EntidadesContext();
        }

        public bool verificaLogin(string login, string senha)
        {
            int verificador = 0;

            var busca = contexto.Usuarios;

            foreach (var log in busca)
            {
                if (log.Login.Equals(login) && log.Senha.Equals(senha))

                verificador++;
            }

            if (verificador > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
