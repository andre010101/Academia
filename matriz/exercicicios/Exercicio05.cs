//5) Leia duas matrizes 2x3 de números double. 
//Imprima a soma destas duas matrizes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace matriz.exercicicios
{
    internal class Exercicio05
    {
        public static void Ex05()
        {


            int i, j;
            int somaColuna, somaLinha;
            int[,] matriz = new int[2, 3];
            int[,] matriz2 = new int[2, 3];

            somaColuna= 0;
            somaLinha= 0;
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write($"Matriz matriz[3,2]\ndigite o indice  [ {i},{j} ]");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }

            }

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {

                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  \n ");
                }
                Console.WriteLine();

            }

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write($"Matriz matriz[3,2]\ndigite o indice  [ {i},{j} ]");
                    matriz2[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }

            }

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {

                    Console.Write("[" + i + "," + j + "] = " + matriz2[i, j] + "  \n ");
                }
              

            }

            for (i = 0; i < 2; i++)
            {


                for (j = 0; j < 3; j++)
                {

                    somaLinha = matriz[i, j] + matriz2[i, j];
                    //somaLinha = matriz[i,0] + matriz[i, 1] + matriz2[i, 0] + matriz2[i, 1];


                }
                

            }
            Console.WriteLine($"dadas {somaLinha}  ");
            Console.WriteLine();
      


        }

    }      
 }
  
