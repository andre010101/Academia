//3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.exercicicios
{
    internal class Exercicio03
    {
        public static void Ex03()
        {
            int c, l;
            int[,] matriz = new int[4,4];

            for (l = 0; l < 4; l++)
            {
                for (c = 0; c < 4; c++)
                {
                    Console.Write($"Matriz matriz[4,4]\ndigite o indice  [ {l},{c} ]");
                    matriz[c,l] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
                
            }

            for(l = 0; l < 4; l++)
            {
                for(c = 0; c < 4; c++)
                {
                    if (l == c)
                    {
                         matriz[l, c] = matriz[l, c] ;
                        Console.WriteLine($"{matriz[l, c]}");
                    }
                        
                }
                Console.WriteLine();

            }


        }



    }
}
