//2.Fazer um programa em VS que popule uma lista com números inteiros (0 a 1000) que sejam sorteados
//randomicamente. O programa deve pedir ao usuário quantos números deseja armazenar. Ao final, o programa
//deve exibir os números populados na lista.








using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientada_a_objeto.NovaPasta
{
    internal class Exercicio02
    {
        public static void Ex02()
        {

            List<int> numeros = new List<int>();
            int numerosArmazenar,continuar;

            Random gerador = new Random();

            int nuemrosAleatotio = gerador.Next(1, 1000);
            Console.WriteLine(nuemrosAleatotio);
            numeros.Add(nuemrosAleatotio);

            do
            {

                Console.WriteLine("quantos numeros deseja armazenar");
                numerosArmazenar = int.Parse(Console.ReadLine());
                if (numeros.Contains(numerosArmazenar))
                {
                    Console.WriteLine("Numero ja cadastrado");

                }
                else
                {
                    numeros.Add(numerosArmazenar);
                }
                Console.Write("1 - para continuar; 2 - para sair: ");
                continuar = int.Parse(Console.ReadLine());
            }
            while (continuar==1);
            numeros.Sort();
            Console.WriteLine("Numeros cadastrados");
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

        }

    }
}
