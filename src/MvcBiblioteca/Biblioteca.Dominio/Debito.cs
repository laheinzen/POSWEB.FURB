﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Biblioteca.Dominio
{
    public class Debito
    {
        public int DebitoId { get; set; }

        [DisplayName("Usuário")]
        public Usuario UsuarioDeb { get; set; }

        public Emprestimo Emprestimo { get; set; }

        [DisplayName("Dias Atraso")]
        public int DiasAtraso { get; set; }

        public bool DebitoAtivo { get; set; }

    }
}
