//10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
//para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
//realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
//notas de menor valor fossem distribuídas em número mínimo possível. 
//Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00,
//três notas de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
//Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
//de acordo com o critério da “distribuição ótima”.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01.Exercicios
{
    internal class Exercicio10
    {
        public static void Ex10()
        {
            double saque = 0;
            int total100 = 0, total50 = 0, total20 = 0, total10 = 0, total5 = 0, total2 = 0, total1 = 0;
            Console.WriteLine("Informar o valor do saque:");
            saque = double.Parse(Console.ReadLine());
            total100 = (int)(saque / 100);
            Console.WriteLine("Notas de 100: " + total100);
            saque = saque - (100 * total100);
            total50 = (int)(saque / 50);
            Console.WriteLine("Notas de 50: " + total50);
            saque = saque - (50 * total50);
            total20 = (int)(saque / 20);
            Console.WriteLine("Notas de 20: " + total20);
            saque = saque - (20 * total20);
            total10 = (int)(saque / 10);
            Console.WriteLine("Notas de 10: " + total10);
            saque = saque - (10 * total10);
            total5 = (int)(saque / 5);
            Console.WriteLine("Notas de 5: " + total5);
            saque = saque - (5 * total5);
            total2 = (int)(saque / 2);
            Console.WriteLine("Notas de 2: " + total2);
            saque = saque - (2 * total2);
            total1 = (int)(saque / 1);
            Console.WriteLine("Notas de 1: " + total1);
            saque = saque - (1 * total1);




        }
    }
}

