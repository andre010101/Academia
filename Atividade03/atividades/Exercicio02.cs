
//2.modificar o programa em vs anterior para que ao final ele pergunte ao usuário se ele deseja 
//informar um outro número. caso positivo, o programa em vs deve ser repetido.

//exemplo:
//digite um número inteiro positivo: 8
//numero digitado: 8
//números inteiros pares entre 1 e 8: 2, 4, 6.


//deseja informar outro número (s/n)? s

//digite um número inteiro positivo: 12
//numero digitado: 20
//números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.


//deseja informar outro número (s/n)? n



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade03.atividades
{
    internal class exercicio02
    {

        public static void ex2()
        {
            int numero;
            string outronumero;

            Console.WriteLine("digite um numero inteiro");
            numero = int.Parse(Console.ReadLine());



            while (numero < 0)
            {
                Console.Clear();
                Console.WriteLine("digite um numero inteiro");
                numero = int.Parse(Console.ReadLine());
            }




            Console.WriteLine($"o numero digitado foi {numero}");

            for (int par2 = 0; par2 < numero; par2++)
            {
                if (par2 % 2 == 0)
                {

                    Console.WriteLine($"numeros pares {par2}");
                }
            }

            do
            {
                Console.WriteLine("deseja informar outro número (s/n)? ");
                outronumero = (Console.ReadLine());
                if (outronumero == "s")
                {
                    Console.WriteLine("digite um outro numero");
                    numero = int.Parse(Console.ReadLine());

                }
                if (outronumero == "n")
                {
                    Console.WriteLine($"o numero digitado foi {numero}");
                    break;
                }
            }
            while (outronumero == "s");




            for (int par2 = 0; par2 < numero; par2++)
            {
                if (par2 % 2 == 0)
                {

                    Console.WriteLine($"numeros pares {par2}");
                }
            }







        }


    }
}