//3.Fazer um programa em VS, com uso de menu, com cadastrar emails, listar emails e sair do programa.
//Os emails digitados devem ser cadastrados em uma lista e não pode haver emails duplicados, ou seja,
//o programa deve controlar essa situação. Quando o usuário solicitar a listagem dos emails, além dessa
//lista, o programa deve listar os domínios de emails cadastrados no programa.

//Menu
//1 - Cadastrar email
//2 - Listar 
//3 - Sair 
//Opção: 



using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientada_a_objeto.NovaPasta
{
    internal class Exercicio03
    {
        public static void Ex03()
        {
            List<string> emails = new List<string>();
            List<string> Listar = new List<string>();
            string cadastarEmail;
           string opção, guardados;
            do
            {
                do
                {
                    Console.WriteLine("Escolha uma das opçoes- 1 cadastrar email --   2 - Listar   3 - Sair   ");
                    opção = (Console.ReadLine());
                } while (opção == "");
                if(opção == "1") { 
                do
                {
                    Console.WriteLine("digite um email");
                    cadastarEmail = (Console.ReadLine());

                   
                } while (cadastarEmail.Length < 1);
                    if (emails.Contains(cadastarEmail))
                    {
                        Console.WriteLine("O email ja foi cadastrado");
                    }


                    else
                    {
                        string[] dadosDoCadastro = cadastarEmail.Split('@');
                        Console.ReadLine();
                        emails.Add(cadastarEmail);
                       
                    }
                    Console.WriteLine("Escolha uma das opçoes- 1 cadastrar email --   2 - Listar   3 - Sair   ");
                    if (opção == "2")
                    {


                        Console.WriteLine(dadosDoCadastro);

                    }
                }
              
                 
                





            }
            while (opção == "1");
           
             
        

            
        


            emails.Sort();
            foreach (var item in emails)
            {
                Console.WriteLine($"{ item}");
            }

            foreach (var item2 in Listar)
            {
                Console.WriteLine($"{item2}");
            }



        }
    }
}
