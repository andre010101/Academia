//6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
//isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
//de IPI (única) a ser acrescentada. 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01.Exercicios
{
    internal class Exercicio06
    {
        public static void Ex06()
        {

            double parafusoa, parafusob, ipi, totala, totalb, totalIpia, totalIpib;
            int quantidadea, quantidadeb;

            parafusoa = 1.90;
            parafusob = 1.50;

            quantidadea = 20;
            quantidadeb = 5;

            ipi = 0.8;

            totala = parafusoa * quantidadea;
            totalb = parafusob * quantidadeb;

            totalIpia = totala * ipi;
            totalIpib = totalb * ipi;

            Console.WriteLine($"total com ipi é {(totalIpia)}");
            Console.WriteLine($"total com ipi é {(totalIpib)}");
        }
    }
}

//static void Main(string[] args)
//{
//    Console.WriteLine("Informe o código do parafuso A");
//    int codA = int.Parse(Console.ReadLine());
//    Console.WriteLine("Informe a quantidade de parafusos A");
//    int quantA = int.Parse(Console.ReadLine());
//    Console.WriteLine("Informe o valor do parafuso A");
//    double valorA = double.Parse(Console.ReadLine());
//    Console.WriteLine("Informe o código do parafuso B");
//    int codB = int.Parse(Console.ReadLine());
//    Console.WriteLine("Informe a quantidade de parafusos B");
//    int quantB = int.Parse(Console.ReadLine());
//    Console.WriteLine("Informe o valor do parafuso B");
//    double valorB = double.Parse(Console.ReadLine());
//    Console.WriteLine("Informe o percentual do IPI");
//    double ipi = double.Parse(Console.ReadLine());
//    double totalA, totalB;
//    totalA = (quantA * valorA);
//    totalA = totalA + (totalA * (ipi / 100));
//    totalB = quantB * valorB;
//    totalB = totalB + (totalB * (ipi / 100));
//    Console.WriteLine("Custo total dos parafusos A:" + totalA);
//    Console.WriteLine("Custo total dos parafusos B:" + totalB);
//}