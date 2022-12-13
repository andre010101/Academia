
//6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
//Random random = new Random();
//int randomNumber = random.Next(0, 100);







using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.exercicicios
{
    internal class Exercicio06
    {
        public static void Ex06()
        {
            int i, j;
            int[,] matriz = new int[4, 4];

            Random random = new Random();
            for ( i = 0; i < 4; i++) 
            {
                for ( j = 0; j < 4; j++) 
                {
                    matriz[i, j] = random.Next(0, 9);
                    Console.WriteLine(matriz[i, j]);

                    
                }
              

            }
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {

                    if (matriz[i, j] >= 8 )
                    {
                        Console.WriteLine($"este é{matriz[i, j]} o maior numero");
                    }

                }


            }




          

            Console.ReadKey();




        }

    }
}
