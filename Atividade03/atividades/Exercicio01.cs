

//1.Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
//(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
//Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

//Exemplo:
//Digite um número inteiro positivo: -8
//Valor incorreto!
//Digite um número inteiro positivo: 8
//Numero digitado: 8
//Números inteiros pares entre 1 e 8: 2, 4, 6.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03.atividades
{
    internal class Exercicio01
    {
        public static void Ex01()
        {
            int numero;
            Console.WriteLine("informe um numero positivo");//Le e recebe um numero positivo
            numero = int.Parse(Console.ReadLine());

            while (numero <= 0)//Enquanto o numero for menor que zero, o sistema ficara em loop ate informar um valor positivo
            {
                Console.Clear();
                Console.WriteLine("Informe um numero Positivo");
                numero = int.Parse(Console.ReadLine());

            }

            Console.WriteLine($"Número inteiro pares entre 1 e {numero}");//Mostra em tela o numero digitado na tela 
            for (int par = 0; par < numero; par++)//(par) ganha +1 até chegar no numero digitado
            {
                if (par % 2 == 0)//pega o resto da divisão e compara com 0 caso ele seja 0 ele é par
                {
                    Console.WriteLine($" {par} ");//Mostra na tela os numeros par;
                }

            }

        }
    }
}