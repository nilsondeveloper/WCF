using System;
using System.Collections.Generic;
using NJ.WCF.Host.Entidades;
using NJ.WCF.Host.Interfaces;

namespace NJ.WCF.Host.Applications
{
    public class PessoaApp : IPessoaApp
    {
        public IList<Pessoa> ListarPessoas()
        {
            return new List<Pessoa>()
            {
                new Pessoa(){Nome = "Nilson Costa", DataNascimento = new DateTime(1989,03,28)},
                new Pessoa(){Nome = "José", DataNascimento = new DateTime(1975,04,15)}
            };
        }
    }
}