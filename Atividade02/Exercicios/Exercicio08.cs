
//8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
//Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
//Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
//E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
//total de vendas. 



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02.Exercicios
{
    internal class Exercicio08
    {
        public static void Ex08()
        {

            //totalVendasFuncionario;



            Console.WriteLine("Digite o codigo do funcionario");//Recebe  le o codigo do funcionario 
            int codigo = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o nome do funcionario"); //Recebe  le o nome do funcionario 
            string nome = (Console.ReadLine());

            Console.WriteLine("Digite o salario");
            double salarioBase = double.Parse(Console.ReadLine());//Recebe  le o salario do funcionario 

            Console.WriteLine("total de vendas");
            int totalVendasFuncionario = int.Parse(Console.ReadLine());//Recebe  le o total de  vendas funcionario 

            //bonus em cima das vendas
            double bonusDeCincoPorcento = 0.5;
            double bonusDeSetePorcento = 0.7;
            double bonusDeDezPorcento = 0.10;

            //apliçacao dos bonus em cima do salario
            double salarioBonusCinco = (bonusDeCincoPorcento * salarioBase) + salarioBase;
            double salarioBonusSete = (bonusDeSetePorcento * salarioBase) + salarioBase;
            double salarioBonusDez = (bonusDeDezPorcento * salarioBase) + salarioBase;


            //verificaçao das vendas realizadas.
            if (totalVendasFuncionario > 500 && totalVendasFuncionario <=999)
            {
                Console.WriteLine($"O Funcionario {nome} com o codigo de numero {codigo} recebera {salarioBonusCinco} Reais");

            }
            
            if (totalVendasFuncionario >= 1000 && totalVendasFuncionario <= 4999 )
            {
                Console.WriteLine($"O Funcionario {nome} com o codigo de numero {codigo} recebera {salarioBonusSete} Reais");
            }
            if (totalVendasFuncionario > 5000)
            {
                Console.WriteLine($"O Funcionario {nome} com o codigo de numero {codigo} recebera {salarioBonusDez} Reais");
            }


        }
    }
}
