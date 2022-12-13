
//7) Leia duas matrizes A e B com 3x3 elementos.
//    Construir uma matriz C,
//    onde cada elemento de C é a subtração do elemento correspondente de A com B.








using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.exercicicios
{
    internal class Exercicio07
    {
        public static void Ex07()
        {


            int i, j;
            int[,] matrizA = new int[3,3];
            int[,] matrizb = new int[3, 3];
         
            Random random = new Random();

            for(i = 0; i < 3; i++)  
            {
                for(j = 0; j < 3; j++)
                {
                    matrizA[i, j] = random.Next(0, 9);
                    Console.WriteLine(matrizA[i, j]);
                }
            }

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    matrizb[i, j] = random.Next(0, 9);
                    Console.WriteLine(matrizb[i, j]);
                }

            }
            int[,] matrizc = new int[3, 3];
        
            for (i = 0; i < 3; i++)
            {
                for(j=0; j < 3; j++)
                {
                    matrizc[i, j]= matrizA[i, j] - matrizb[i, j];
                    Console.Write("[" + i + "," + j + "] = " + matrizc[i, j] + "  \n ");
                }
                
               
            }

         
                   

           

        }
    }
}
