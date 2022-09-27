//2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02.Exercicios
{
    internal class Exercicio02
    {
        public static void Ex02()
        {

            int numero, numeroVerifica;

            Console.WriteLine("Digite um numero");
            numero = int.Parse(Console.ReadLine());

            numeroVerifica = numero % 2;
            if (numeroVerifica == 0)
            {
                Console.WriteLine("Este Numero é par");
            }
            else
            {
                Console.WriteLine("Este NUmero é impar");
            }


        }
    }
}
