//11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
//O programa deve exibir se a hora digitada está ou não válida. 
//Lembre que usaremos o padrão de hora com 24h, de 0 a 23.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Atividade02.Exercicios
{
    internal class Exercicio11
    {
        public static void Ex11()
        {
            int hora;
            int minutos;

            


            do {
                Console.WriteLine("digite uma Hora");
                hora = int.Parse(Console.ReadLine());
                if (hora > 23)
                {
                    Console.WriteLine("Hora invalida");
                }
                else if (hora < 0)
                {
                    Console.WriteLine("Hora invalida");
                }
            }
            while (hora <0 || hora > 23);

            do
            {

                Console.WriteLine("Digite os minutos");
                minutos = int.Parse(Console.ReadLine());
                if (minutos > 59)
                {
                    Console.WriteLine("Minuto  invalido");
                }
                else if (hora < 0)
                {
                    Console.WriteLine("Minuto invalida");
                }
            }
            while (hora < 0 || hora > 23);



            Console.WriteLine($"São {hora}:{minutos}");
        }


    }
}
