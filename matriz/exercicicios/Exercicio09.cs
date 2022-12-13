//9) Leia uma matriz 3x3.  Em seguida,
//    solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
//Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.



using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace matriz.exercicicios
{
    internal class Exercicio09
    {
        public static void Ex09()

        {
            int i, j, resultado;
            int[,] matriz = new int[4, 4];
            Random random = new Random();
            bool numeroExite = false;


            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    matriz[i, j] = random.Next(0, 9);
                    Console.WriteLine(matriz[i, j]);

                }
                Console.WriteLine();

            }

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  \n ");
                }




            }
           

            Console.WriteLine("digite um numero");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 8 || numero < 0)
            {
                Console.WriteLine($"(o número não existe no vetor  ");
                
            }

         
            for ( i = 0; i < 4; i++)
            {
                
                for ( j = 0; j < 4; j++)
                {
                    



                    if (numero == matriz[i, j])
                    {


                        numeroExite = true;
                        break;
                       
                    }
                    else
                    {
                        numeroExite = false;
                    }



                }
                Console.WriteLine();
            }

            if(numeroExite)
            {
                Console.WriteLine($"o numero existe ");
            }
            else
            {
                Console.WriteLine("numero nao exite");
            }





        }

    }
}
    



            




  
    

