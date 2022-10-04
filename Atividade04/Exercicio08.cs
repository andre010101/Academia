//8.Fazer um algoritmo que leia trinta números reais
//armazenando-os em um vetor e após escreva a posição
//de cada número menor que zero desse vetor. Exemplo:
//a.lê:          	| 5.1 | 0 | -3.6 | 4.1 | -2.5 | -1.3 | -4 | 1.39 | -128 | -6.9 | 8.2 | 9 | 154 | -88 | 6.4 | 7.1 | ...|
//b.escreve: 	| 3 | 5 | 6 | 7 | 9 | 10 | 14 |. . .



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04
{
    internal class Exercicio08
    {

        public static void Ex08()
        {
            int i, pos;
            double[] numero = new double[30];

            pos = 0;
            for (i = 0; i < 30; i++)
            {
                
                Console.WriteLine("digite um numero");
                numero[i] = double.Parse(Console.ReadLine());

               
            }
         

            for(i = 0; i < 30; i++)
            {
                Console.WriteLine($" {numero[i]}");
                pos = i;
                if (numero[i] < 0)
                {
                    Console.WriteLine($" posição dos numeros menores que zero é {pos+1}");
                }
            }
            

        }
    }
}
