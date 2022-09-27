//6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
//O programa deve calcular o Indice de Massa Corpórea (IMC), exibi - lo ao usuário e informar sua situação conforme a tabela.
//O cálculo do imc = peso / (altura * altura)

//IMC
//menor que 18                -> baixo peso
//maior que 18 e menor que 25 -> peso normal
//maior que 25 e menor que 30 -> sobrepeso
//maior que 30 e menor que 35 -> obesidade
//maior que 35                -> obesidade grau sério



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02.Exercicios
{
    internal class Exercicio06
    {
        public static void Ex06()
        {
            double Peso, imc;
            string Nome, Nome2;
            double Altura;

            Console.WriteLine("Digite o seu nome e sobrenome");//Recebe o nome.
            Nome = Console.ReadLine();


            Console.WriteLine("Digite a sua Altura");//Recebe a altura
            Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Seu Peso");//Recebe o Peso.
            Peso = double.Parse(Console.ReadLine());

            imc = Peso / (Altura * Altura);//Calculo do imc


            Console.WriteLine($"O seu imc é de {Math.Round(imc, 0)}");//Retorno do imc.
            Console.WriteLine(Nome.ToUpper());//Transfoma o nome em maiusculo 
            Console.WriteLine($"Sua altura é de {Altura} Metros");//Altura digitada.
            Console.WriteLine($"O seu peso é de  {Peso}  Kilos");//Peso digitada.


            if (imc <= 18)
            {
              
               
                Console.WriteLine($" Imc de {Math.Round(imc,0)} abaixo do peso");
            }
            else if (imc > 18 && imc < 25)
            {
                Console.WriteLine($" Imc de {Math.Round(imc, 0)} peso normal ");
            }
            if (imc > 25 && imc < 30)
            {
                Console.WriteLine($" Imc de {Math.Round(imc, 0)} sobrepeso ");
            }
            else if (imc > 30 && imc < 35)
            {
                Console.WriteLine($" Imc de {Math.Round(imc, 0)} obesidade");
            }
            if (imc >= 35)
            {
                Console.WriteLine($" Imc de {Math.Round(imc, 0)} obesidade grau sério");
            }
        }
    }
}
