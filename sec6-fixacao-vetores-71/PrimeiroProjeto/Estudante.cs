using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class Estudante
    {
        //declarou as duas strings, nome e email com properties get e set
        public string Nome { get; set; }
        public string Email { get; set; }

        //construtor gerado
        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        //override para escrever na tela nome e email
        public override string ToString()
        {
            return Nome + ", " + Email;
        }

    }
}
