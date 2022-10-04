//5.Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04
{
    internal class Exercicio05
    {
        public static void Ex05()

        {
            int i, pos, menor, posMenor;
            int[] vetor = new int[10];

          
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"digite o valor do elemento {i+1}" );
                vetor[i] = int.Parse(Console.ReadLine());
                
            }

            // Encontre e mostre o menor elemento e a sua posição.


            pos = 0; ///1,2,3,4,5
            posMenor = 0;


            menor = vetor[0];
            for (i = 0; i < 10; i++)
            {


                pos = i;

             
                if (vetor[i] < menor )
                {

                    menor = vetor[i];
                    posMenor = i;
                    
                }
             

            }
            Console.WriteLine($"  menor {menor}  na posição {posMenor+1}");

        }


    }
}
