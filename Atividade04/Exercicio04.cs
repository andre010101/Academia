
//4.Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04
{
    internal class Exercicio04

    {
        public static void Ex04()
        {

            int[] resultado = new int[10];

            int i;
            int[] numero = new int[10];
           
         
            for (i = 0; i <10; i++)
            {
                Console.WriteLine($"digite um elemento do vetor");
                numero[i] = int.Parse(Console.ReadLine());
               

            }

           
            int[] numero2 = new int[10];
          

            for (i = 0; i <10; i++)
            {
                Console.WriteLine($"digite um elemento do segundo vetor");
                numero2[i] = int.Parse(Console.ReadLine());

               
               
            }
           
            for (i = 0; i < 10; i++)
            {
                resultado[i] = numero[i] * numero2[i];
                  
    
                Console.WriteLine($" {numero[i]} X {numero2[i]} = {resultado[i]} ");

            }
           
        }
    }
}