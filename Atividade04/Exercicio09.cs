//9.Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e em seguida ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04
{
    internal class Exercicio09
    {

        public static void Ex09()
        {
            int[] vetor = new int[5] { 10, 7, 3, 4, 2 };
            int aux = 0;
            //o vetor é percorrido com o uso de um laço auxiliar para a ordenação
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //verifica se a valor atual é menor que o próximo valor
                    if (vetor[j + 1] < vetor[j])
                    {
                        //inverte-se o valor caso a condição acima seja verdadeira
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }
            //mostra o vetor ordenado
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("vetor[" + i + "] = " + vetor[i]);
            }

        }
    }
    
}
