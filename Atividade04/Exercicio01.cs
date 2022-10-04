//1.Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04
{
    internal class Exercicio01
    {
        public static void Ex01()
        {
            int i, pares, impa;
            int[] numero = new int[10];
            Console.WriteLine("Digite 10 números (pressione Enter para cada número");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("digite o valor " + i + ":");
                numero[i] = int.Parse(Console.ReadLine());
            }
           
            for (i = 0; i < 10; i++)
            {
                if (numero[i] % 2 == 0)
                {

                    pares = numero[i];

                    Console.WriteLine($"o numero par é {pares}");
                    
                }
                else
                {
                    impa = numero[i];
                    Console.WriteLine($"o numero impa é {impa}");
                }

                
            }
               
           
        }
    }
}
