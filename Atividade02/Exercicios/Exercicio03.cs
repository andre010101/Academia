//3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02.Exercicios
{
    internal class Exercicio03
    {
        public static void Ex03()

        {
            int Num1, Num2, Num3, Num4,media;

            Num1 = 9;
            Num2 = 10; 
            Num3 = 5;
            Num4 = 6;

            media =  (Num1 + Num2 + Num3 + Num4) / 4;

            Console.WriteLine($"A media é de {media}");
            
            if (media < Num1)
            {
                Console.WriteLine($"Superio a Media Numero1 {Num1}");
            }
             if (media < Num2)
            {
                Console.WriteLine($"Superio a Media Numero2 {Num2}");
            }
             if(media < Num3)
            {
                Console.WriteLine($"Superio a Media Numero3 {Num3}");
            }
           else if (media < Num4)
            {
                Console.WriteLine($"Superio a Media Numero4{Num4}");
            }
        }
    }
}
