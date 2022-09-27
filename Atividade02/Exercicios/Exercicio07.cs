//7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
//O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
//exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02.Exercicios
{
    internal class Exercicio07
    {

        public static void Ex07()
        {
            String frase = "";
            String palavra = "";
            Console.WriteLine("Digite um frase:");
            frase = Console.ReadLine();
            Console.WriteLine("Digite uma palavra");
            palavra = Console.ReadLine();
            if (frase.Contains(palavra))
            {
                Console.WriteLine("A palavra encontra-se na frase!");
            }
            else
            {
                Console.WriteLine("A palavra não encontra-se na frase!");
            }
        }


    }
}
