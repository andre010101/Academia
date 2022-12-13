using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Runtime.Serialization;

namespace laçosDeRepetição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int soma = 0;
            //for (int i = 56; i < 127; i++)
            //{
            //    soma += i;
            //}
            //Console.WriteLine(soma);


            //int contagem = 0;
            //double salario = 1000;
            //for (; salario < 5000; salario = salario + 700)
            //{
            //    contagem++;
            //}
            //Console.WriteLine(contagem);
            //Console.WriteLine(salario);


            //contar quantos pares existem entre 55 e 127

            //int contar = 0;
            //int par = 0;



            //for (int i = 55; i < 127; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        contar++;
            //    }

            //    Console.WriteLine(contar);
            //}


            //contar os impare e somar os pares existentes 55  e 127 
            //int contar = 0;
            //int soma = 0;



            //for (int i = 55; i < 127; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        contar++;
            //    }
            //    else
            //    {
            //        soma += i;
            //    }




            //}
            //Console.WriteLine($" ipa{soma} par{contar}");

            //Console.WriteLine("escolha 1 numero");
            //int numero1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("escolha 2 numero");
            //int numero2 = int.Parse(Console.ReadLine());


            //int contar = 0;
            //int soma = 0;



            //for (int i = (numero1+1); i < numero2; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        contar++;
            //    }
            //    else
            //    {
            //        soma += i;
            //    }




            //}
            //Console.WriteLine($" ipa{soma} par{contar}");

            //Console.WriteLine("Digite o valor inicial");
            //int inicio = int.Parse(Console.ReadLine());
            //int fim = 0;
            //while (inicio > fim)
            //{
            //    Console.WriteLine("Digite o valor final");
            //    fim = int.Parse(Console.ReadLine());
            //}
            //int contagem = 0;
            //int soma = 0;
            //for (int i = (inicio + 1); i < fim; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        contagem++;
            //    }
            //    else
            //    {
            //        soma += i;
            //    }
            //}
            //Console.WriteLine("Contem " + contagem + " números " +
            //    "impares e a soma dos pares resulta em " + soma);


            //int i = 1;

            //while (i<=10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int valor = -1;
            //do
            //{
            //    Console.WriteLine("Digite um valor");
            //    valor = int.Parse(Console.ReadLine());
            //} while (valor > 0);

            //contar qauntos valores o usuario digitou
            //até ele digitar um valor negativo


            int contagem  = 0;
            int valor = 0;

            while (true)
            {
                Console.WriteLine("digite um valor");
                valor = int.Parse(Console.ReadLine());

                if(valor < 0)
                {
                    break;
                }

                if(valor % 2 ==0)
                {
                    contagem++;
                }
                Console.WriteLine(contagem);
                
            } 


        }

    }
}