//1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha.
//A 2ª coluna, some 10 aos elementos da 1ª coluna. Na 3º coluna,
//armazene o dobro dos elementos da 1ª coluna.


using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace matriz.exercicicios
{
    internal class Exercicio01
    {
        public static void Ex01()
        {

            //informa o valor da 1 colulna
            int[,] matriz = new int[5, 3];
            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine("Informe um valor para a coluna 0: ");
                matriz[c, 0] = int.Parse(Console.ReadLine());
            }


            for (int c = 0; c < 5; c++)
            {
                matriz[c, 1] = matriz[c, 0] + 10;
                matriz[c, 2] = matriz[c, 0] * 2;
            }
            for (int c = 0; c < 5; c++)
            {
                for (int l = 0; l < 3; l++)
                {
                    Console.Write("[" + l + "," + c + "] = " + matriz[c, l] + "  ");
                }
                Console.WriteLine();
            }



        }
    }
}
