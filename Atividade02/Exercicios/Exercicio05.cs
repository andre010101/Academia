//5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
//se a média das duas notas for maior ou igual a 7,0. 

//Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
//é a média entre a nota do exame e a média das 2 notas. 
//Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve 
//escrever “Reprovado”.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02.Exercicios
{
    internal class Exercicio05
    {
        public static void Ex05()
        {
            int Nota1, Nota2, Media,Exame;


            Console.WriteLine("Digite a primeira nota");
            Nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            Nota2 = int.Parse(Console.ReadLine());


            Media = (Nota1 + Nota2) / 2;

            Console.WriteLine($"A media é de {Media}");

            if (Media< 7)
            {

                Console.WriteLine("Digite a nota do Exame");
                Exame = int.Parse(Console.ReadLine());
                if ((Exame + Media) / 2 >= 5)
                {
                    Console.WriteLine("Aluno Aprovado");
                }
                else
                {
                    Console.WriteLine("Aluno Reprovado");
                }

            }
            if (Media >= 7)
            {
                Console.WriteLine("Aluno Aprovado");
            }
        }
    }
}
