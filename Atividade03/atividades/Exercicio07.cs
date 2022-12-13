

//7.Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
//A cada solicitação, teste se o usuário informou um valor válido. 
//Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
//informe que ele está incorreto e saia do programa em VS. 
//Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
//informe que está errada e saia. Se estiver correta, solicite o salário. 
//Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
//Se estiver correto, mostre todos os valores lidos.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Atividade03.atividades
{
    internal class Exercicio07
    {
        public static void Ex07()

       
        {

            string nullString = null;
            string emptyString = "";
            string spaceString = "    ";
            string tabString = "\t";
            string newlineString = "\n";
            string nonEmptyString = "texto";

            string nome;
            int salario;

           
                do
            {

               Console.WriteLine(string.IsNullOrEmpty(nonEmptyString));
                nome= Console.ReadLine();   


                Console.WriteLine("Digite o seu salario");
                salario = int.Parse(Console.ReadLine());
                if (salario <=0)
                {
                    Console.WriteLine("Digite o seu salario");
                  
                }

            } while (false );

            Console.WriteLine($"aaaaaaaa{nome}");
        
        }


    }
}
