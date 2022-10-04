
//6.Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
//a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
//b.escreve: 	| 22 | 7 | 31 | 63 | 0 | 21 | 9 | 3 | 40 | 7 |


using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04
{
    internal class Exercicio06
    {
        public static void Ex06()
        {
            int i;
            int[] le = new int[10];
        
            for (i = 0; i < 10; i++)
            {

                Console.WriteLine("digite um numero ");
                le[i] = int.Parse(Console.ReadLine());


            }

     
            for (i=10-1;i >0;i--)
            {

               

                Console.WriteLine(le[i]);
            }
            Console.WriteLine(le[i]);
        }




    }
}
