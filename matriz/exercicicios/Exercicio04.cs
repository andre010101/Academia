//4) Popule uma matriz 5x5 e informe:
//-Quantos números são pares
//-Quantos números são impares
//-Quantos números são positivos
//-Quantos números são negativos
//-Quantos zeros existem!



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz.exercicicios
{
    internal class Exercicio04
    {
        public static void Ex04()
        {
            int l, c , pares, impares, positivos, negativos,zero;
            int[,] matriz = new int[3, 3];

            pares = 0;
            impares = 0;
            positivos = 0;
            negativos = 0;
            zero = 0;
            for (c = 0;c < 3; c++)
            {
                for (l = 0; l < 3; l++)
                {
                    Console.Write($"Matriz matriz[4,4]\ndigite o indice  [ {c},{l} ]");
                    matriz[c, l] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }

            }

            for ( c = 0; c < 3; c++)
            {
                for(l = 0; l < 3; l++)
                {
                    if (matriz[c, l] % 2 == 0)
                    {
                        pares++;
                        
                    }
                    else if (matriz[l, c] % 2 == 1)
                    {
                        impares++;
                    }
                    if (matriz[c, l] > 0)
                    {
                        positivos++;
                    }
                     else if (matriz[c, l] < 0)
                    {
                        negativos++;
                    }
                    if (matriz[c, l] == 0)
                    {
                        zero++;
                    }



             
                }
                
            }
            Console.WriteLine($"tem um total de { pares} numeros pares");
            Console.WriteLine($"tem um total de {impares} numeros impares");
            Console.WriteLine($"tem um total de {positivos} numeros positivos");
            Console.WriteLine($"tem um total de {negativos} numeros negativivo");
            Console.WriteLine($"tem um total de {zero} zeros");
        }
    }
}
