//9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
//do que ou igual às duas prestações, que devem ser iguais, inteiras e as maiores possíveis. 
//Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00;
//se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
//Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
//da entrada e das duas prestações, de acordo com as regras acima. 
//Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
//conseqüente pagamento dos boletos das duas prestações.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01.Exercicios
{
    internal class Exercicio09
    {
        public static void Ex09()
        {
            double valorProduto, entrada, prestaçoesRestantes, parcela;

            Console.WriteLine("digite o valor total do produto");
            valorProduto = double.Parse(Console.ReadLine());

            entrada = valorProduto / 3;
            prestaçoesRestantes = valorProduto - entrada;
            parcela = valorProduto / 3;


            Console.WriteLine($"o valor da entrada é de {entrada} reais");
            Console.WriteLine($"você ainda de pagar o total {prestaçoesRestantes} reais dividido em 2 parcelas de {parcela}reais ");

        }
    }
}
