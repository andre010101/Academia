//10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
//para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
//realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
//notas de menor valor fossem distribuídas em número mínimo possível. 
//Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00,
//três notas de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
//Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
//de acordo com o critério da “distribuição ótima”.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01.Exercicios
{
    internal class Exercicio10
    {
        public static void Ex10()
        {
            int Notas50, Notas20, Notas10, Notas5, Notas1, ValorSaque, NotaRecebida;

            Console.WriteLine("digite o valor do saque");
            ValorSaque = int.Parse(Console.ReadLine());

            for (int Nota20 = 20; Nota20 < ValorSaque; Nota20 ++) 
            {
                NotaRecebida = ValorSaque / Nota20;
                Console.WriteLine(NotaRecebida);
            }






        }
    }
}

