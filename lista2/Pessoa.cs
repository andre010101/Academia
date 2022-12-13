using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2
{
    internal class Pessoa
    {
        public Pessoa() { }
        public string Nome { get; set; }    
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
           this.Nome = nome;
            this.Idade = idade;
        }


    }
}
