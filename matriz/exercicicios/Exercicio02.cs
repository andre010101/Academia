//2) Solicite ao usuário, preencher uma Matriz 3x3

//Informe ao usuário:
//*A soma dos elementos de cada linha
//	-Ex: Linha 1: 30

//         Linha 2: 17
//* A soma dos elementos de cada coluna
//	-Ex: Coluna 1: 23

//         Coluna 2: 36



using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.exercicicios
{
    internal class Exercicio02
    {
        public static void Ex02()
        {

            int c, l, linha, coluna;
            int[,] matriz = new int[3, 3];



            for ( c = 0; c < 3; c++)
            {
                for ( l = 0; l < 3; l++)
                {
                    Console.WriteLine("Informe um valor para a posição " + c + " - " + l + " da matriz:");
                    matriz[c, l] = int.Parse(Console.ReadLine());
                }
               
            }
          
           
            //mostrando o conteúdo da matríz
            for ( c = 0; c < 3; c++)
            {
                for ( l = 0; l < 3; l++)
                {
                    Console.Write("[" + c + "," + l + "] = " + matriz[c, l] + "  \n ");
                }
                
            


            }

            for (c = 0; c < 3; c++)
            {
                coluna = matriz[0, c] + matriz[1, c] + matriz[2, c];




                Console.Write($" a soma das coluna {c} é {coluna} \n");

            }

            for (l = 0; l < 3; l++)
            {
                linha = matriz[l, 0] + matriz[l, 1] + matriz[l, 2];


                Console.Write($" a soma das linhas {l} é {linha} \n");

            }
            Console.WriteLine();




        }
    }
}
