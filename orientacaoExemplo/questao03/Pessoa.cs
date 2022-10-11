using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoExemplo.aluguel
{
    internal class Pessoa
    {
        public string nome { get; set; }
        public double CPF { get; set; }
        public double telefone { get; set; }



        public void ApresentarPessoa()
        {
            Console.WriteLine($"O cliente {nome} portador do CPF: {CPF} Telefone {telefone} ");
        }
    }
}
