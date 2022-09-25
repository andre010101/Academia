using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01.Exercicios
{ 
    internal class Exercicio11
    {
        public static void Ex11()
        {
            int NumeroEleitores, votosBrancos, votosNulos, votosValidos, percentualBracos, votosInvalidos, percentualBrancosTotal, percentualNunos, percentualNulosTotal;

            NumeroEleitores = 100;
            votosBrancos = 20;
            votosNulos = 10;

            votosInvalidos = votosBrancos + votosNulos;
            votosValidos = NumeroEleitores - votosInvalidos;

            percentualBracos = NumeroEleitores * votosBrancos;
            percentualBrancosTotal = percentualBracos / 100;

            percentualNunos = NumeroEleitores * votosNulos;
            percentualNulosTotal = percentualNunos / 100;


            Console.WriteLine($"total de eleitores  {NumeroEleitores}");
            Console.WriteLine($"percentual de votos brancos é de  {percentualBrancosTotal}%");
            Console.WriteLine($"percentual de votos nulos é de {percentualNulosTotal}%");
            Console.WriteLine($"percentual de votos nulos é de {votosValidos}%");
        }
    }
}