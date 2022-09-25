
//5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
//(medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
//consumido para percorrê-la (medido em l).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01.Exercicios
{
    internal class Exercicio05
    {
        public static void Ex05()
        {
            int kilometros, combustivel;
            double consumomedio;

            kilometros = 816;
            combustivel = 60;
            consumomedio = 816 / 60;


            Console.WriteLine($"o consumo medio do automovel foi de {consumomedio}km/l");
        }

    }
}
