//10) leia duas matrizes a e b de 4x4 elementos, calcule a média dos mesmos, 
//    em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.exercicicios
{
    internal class Exercicio10
    {
        public static void Ex10()
        {

            int[,] matrizA = new int[4,4];
            int[,] matrizB = new int[4,4];
            int[,] media = new int[4, 4];
           
            Random random = new Random();


            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    matrizA[i,j] = random.Next(0,9);
                    Console.WriteLine(matrizA[i, j]);

                   
                }
               
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" matrizA[" + i + "," + j + "] = " + matrizA[i, j] + "  \n ");
                  
                }
               
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrizB[i, j] = random.Next(0, 9);
                    Console.WriteLine(matrizA[i, j]);
                    
                }
              

            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("matrizB[" + i + "," + j + "] = " + matrizB[i, j] + "  \n ");
                    
                }
               

            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    media[i, j] = (matrizA[i, j] + matrizB[i, j]) / 2;
                    Console.Write("media["+ i + "," + j +"] = " + media[i, j] + "  \n ");
                }
                Console.WriteLine();
            }

        }


    }
}
