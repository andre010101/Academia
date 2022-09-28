

//2.Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
//informar um outro número. Caso positivo, o programa em VS deve ser repetido.
 
//Exemplo:
//Digite um número inteiro positivo: 8
//Numero digitado: 8
//Números inteiros pares entre 1 e 8: 2, 4, 6.


//Deseja informar outro número (s/n)? S
 
//Digite um número inteiro positivo: 12
//Numero digitado: 20
//Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.


//Deseja informar outro número (s/n)? N



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03.atividades
{
    internal class Exercicio02
    {

        public static void Ex2()
        {
            int numero;
            string outroNumero;

            Console.WriteLine("Digite um numero inteiro");
            numero = int.Parse(Console.ReadLine());

           

            while (numero < 0)
            {
                Console.Clear();
                Console.WriteLine("Digite um numero inteiro");
                numero = int.Parse(Console.ReadLine());
            }




            Console.WriteLine($"o numero digitado foi {numero}");

            for (int par2 = 0; par2 < numero; par2++)
            {
                if (par2% 2 == 0)
                {

                    Console.WriteLine($"numeros pares {par2}");
                }
            }

            do
            {
                Console.WriteLine("Deseja informar outro número (s/n)? ");
                outroNumero = (Console.ReadLine());
                if (outroNumero == "s")
                {
                    Console.WriteLine("Digite um outro numero");
                    numero = int.Parse(Console.ReadLine());

                }
                if (outroNumero == "n")
                {
                    Console.WriteLine($"o numero digitado foi {numero}");
                    break;
                }
            }
            while (outroNumero == "s");

            


            for (int par2 = 0; par2 < numero; par2++)
            {
                if (par2 % 2 == 0)
                {

                    Console.WriteLine($"numeros pares {par2}");
                }
            }






            //for (int par = 0; par < numero2; par++)
            //{
            //    if (par % 2 == 0)
            //    {

            //        Console.WriteLine($"numeros pares {par}");
            //    }
            //}

        }


    }
}
