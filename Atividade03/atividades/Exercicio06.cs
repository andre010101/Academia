
//6.Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados,
//ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
//Ao final, mostre a idade digitada.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03.atividades
{
    internal class Exercicio06
    {
        public static void Ex06()

        {
            int idade;
            do
            {
                Console.WriteLine("Digite a sua idade");
                idade=int.Parse(Console.ReadLine());
                
            } while (idade<0);
            Console.WriteLine($"A idade digitada foi {idade} anos ");
        }
      
    }
}
