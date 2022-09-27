
//1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
//Área do triangulo = (base * altura) / 2;
//Teste se a base ou a altura digitada não foi igual a zero.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02.Exercicios
{
    internal class Exercicio01
    {
        public static void Ex01()
        {
            int BaseTriangulo, AlturaTriangulo,AreaDoTriangulo;



            Console.WriteLine("digite a base do triangulo");
            BaseTriangulo = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a AlturaTriangulo");
            AlturaTriangulo = int.Parse(Console.ReadLine());
            AreaDoTriangulo = (BaseTriangulo * AlturaTriangulo) / 2;
            Console.WriteLine($"Tamnho da area do trinagulo é de {AreaDoTriangulo}");

            if (BaseTriangulo <= 0)
            {
                Console.WriteLine("A base tem que ser maior que zero");
            }

            if (AlturaTriangulo <= 0)
            {
                Console.WriteLine("A Altura tem que ser maior que zero");
            }
        }
    }
}
