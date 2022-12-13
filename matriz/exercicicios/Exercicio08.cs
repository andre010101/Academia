//8) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.exercicicios
{
    internal class Exercicio08
    {
        public static void Ex08()

        {
            int i, j;

            int[,] matri = new int[4,4];

            Random random = new Random();

            for(i=0; i<4; i++)  
            {
                for (j = 0; j < 4; j++)
                {
                    matri[i, j] = random.Next(0, 9);
                    Console.WriteLine(matri[i, j]);
                }
            }

          

            for (i =3 ; i >-1; i--)
            {
                for (j = 3; j >-1; j--)
                {

                    Console.WriteLine($"([{i}] , [{j}]={matri[i, j]}");

                }

            }



        }
    }
}
