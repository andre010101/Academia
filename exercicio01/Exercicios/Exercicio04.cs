

//4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
//forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01.Exercicios
{
    internal class Exercicio04
    {
        public static void Ex04()

        {
            string Dia, Mes, Ano, DataAtual;




           


            Console.WriteLine($"digite a data atual ");
            DataAtual = (Console.ReadLine());
            Dia =  DataAtual.Substring(0, 2);
            Mes = DataAtual.Substring(2, 2);
            Ano = DataAtual.Substring(4, 4);
            Console.WriteLine($"data {Ano} {Mes} {Dia} ");

            Ano = DataAtual.Substring(6, 2);
            Mes = DataAtual.Substring(2, 2);
            Dia = DataAtual.Substring(0, 2);
            Console.WriteLine($"data {Ano} {Mes} {Dia} ");
            DataAtual = (Console.ReadLine());
           
            
           
        }
    }
}