using orientacaoExemplo.aluguel;
using orientacaoExemplo.questao05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoExemplo.questao06
{
    public class Pessoa1
    {
        public Pessoa1(string nome, int idade, float altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
        }

        public string nome;
        public int idade;
        public float altura;


        public void MostraDados()
        {
            Console.WriteLine("Pessoa nome: " + this.nome + " idade: " + this.idade + " altura: " + this.altura);
        }

    }
}
