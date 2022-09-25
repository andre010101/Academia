//3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
//si os valores de duas variáveis A e B.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01.Exercicios
{
    internal class Exercicio03
    {
        public static void Ex03()
        {

            int a, b;

            a = 10;
            b = 6;

            a += b; a = 16;
            b = a - b; b = 10;
            a -= b; a = 6;


            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
