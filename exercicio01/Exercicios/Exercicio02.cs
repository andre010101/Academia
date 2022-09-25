
//2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01.Exercicios
{
    internal class Exercicio02
    {

        public static void Ex02()
        {
            float num1, num2, num3, num4;
            float media;
            float total;

            num1 = 10;

            num2 = 8;

            num3 = 5;

            num4 = 10;

            total = num1 + num2 + num3 + num4;

            media = total / 4;


            Console.WriteLine(media);
        }
    }
}
