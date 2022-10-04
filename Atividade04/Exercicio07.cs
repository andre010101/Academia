//7.Fazer um algoritmo que leia dez números inteiros
//armazenando-os em um vetor e escreva primeiramente todos os
//números pares lidos e após todos os ímpares. Exemplo:
//a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
//b.escreve: 	| 40 | 0 | 22 | 7 | 3 | 9 | 21 | 63 | 31 | 7 |



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04
{
    internal class Exercicio07
    {

        public static void Ex07()


        {
            int i;
            int[] numero = new int[10];
           

            for (i = 0; i < 10; i++)
            {

                Console.WriteLine("digite um numero");
                numero[i] = int.Parse(Console.ReadLine());


            }
      
            


            for (i = 0; i < 10; i++)
            {

                

                
                if(numero[i] % 2 == 0)
                {
                    Console.WriteLine($"  Os numeros pares são {numero[i]}  ");
                }
                
          
            }
            for (i = 0; i < 10; i++)
            {




                if (numero[i] % 2 == 1)
                {
                    Console.WriteLine($" Os numeros imapares são  {numero[i]}  ");
                }


            }

        }
    }
}


