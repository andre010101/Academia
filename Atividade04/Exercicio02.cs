//2.Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04
{
    internal class Exercicio02
    {
        public static void Ex02()
        {

            int i, soma1, soma2, total;
            int[] numero = new int[20];
            Console.WriteLine("Digite 10 números (pressione Enter para cada número");

            soma1 = 0;
            
            for (i = 0; i < 20; i++)
            {
                
                numero[i] = int.Parse(Console.ReadLine());
                soma1 += numero[i];
                Console.WriteLine(soma1);
            }
            soma2 = soma1;


            int[] numero2 = new int[20];
            Console.WriteLine("digite 10 números (pressione enter para cada número");
            soma1= 0;
           
            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("digite o valor " + i + ":");
                numero2[i] = int.Parse(Console.ReadLine()) ;
                soma2 += numero2[i];
            }

            total = soma2 + soma1;
            Console.WriteLine(total);


        }
    }



}





