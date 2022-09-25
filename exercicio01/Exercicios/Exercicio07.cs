

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01.Exercicios
{
    internal class Exercicio07
    {
        public static void Ex07()
        {

            int codigoVendedor, totalVendas;
            double salarioFixo, percentual, salarioTotal, percentualVendas;



            codigoVendedor = 789;
            salarioFixo = 900.00;
            totalVendas = 50;
            percentual = 0.50;


            percentualVendas = totalVendas * percentual;
            salarioTotal = percentualVendas * totalVendas;

            Console.WriteLine($"o vender com codigo {codigoVendedor} realizou um total de {totalVendas} vendas, e o seu salario bruto ficou em {percentualVendas + salarioFixo} reais");

        }
    }
}
