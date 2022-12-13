//10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
//O programa deve mostrar os dados do atleta mais novo e mais alto.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02.Exercicios
{
    internal class Exercicio10
    {
     public static void Ex10()

        {
            //recebe e armazena as informacoes do atleta 1
            Console.WriteLine("Digite o nome do atleta numero 1");
            string nomeAtleta1 = Console.ReadLine();

            Console.WriteLine("Digite a idade do atleta numero 1");
            int idadeAtleta1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do atleta numero 1");
            double alturaAlteta1 = double.Parse(Console.ReadLine());

            //recebe e armazena as informacoes do atleta 2
            Console.WriteLine("Digite o nome do atleta numero 2");
            string nomeAtleta2 = Console.ReadLine();

            Console.WriteLine("Digite a idade do atleta numero 2");
            int idadeAtleta2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do atleta numero 2");
            double alturaAlteta2 = double.Parse(Console.ReadLine());


            if (idadeAtleta1 < idadeAtleta2 && alturaAlteta1 > alturaAlteta2) 
            {
                Console.WriteLine("atleta 1");
            }
            if(idadeAtleta2 < idadeAtleta1 && alturaAlteta2 > alturaAlteta1)
            {
                Console.WriteLine("atleta 2");
            }
        }
    }
}
