﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Entidades
{
     public class Usuario
    {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Login { get; set; }
            public string Senha { get; set; }
            public int Perfil { get; set; }
            public string Ativo { get; set; }
    }
}
