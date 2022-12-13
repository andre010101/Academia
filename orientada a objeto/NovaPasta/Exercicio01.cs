//1.Fazer um programa em VS que popule uma lista de nomes, com nomes completos obrigatoriamente.
//Ao cadastrar o nome na lista, o nome deve ser validado para que tenha no mínimo duas palavras e 
//que não esteja na lista. Ao final, caso o nome não esteja na lista, cadastra-lo em maiúsculo e 
//exibir a lista ordenada.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientada_a_objeto.NovaPasta
{
    internal class Exercicio01
    {

        public static void Ex01()
        {
            string nome;
            List<string> nomesPessoas = new List<string>();
            int continuar;
           
            string[] dadosNome;
            do
            {
                do
                {
                    Console.WriteLine("Digite seu nome completo ");
                    nome = Console.ReadLine().ToUpper();
                    dadosNome = nome.Split(" ");
                    Console.WriteLine(dadosNome[0]);
                }
                while (dadosNome.Length <= 1);

                if (nome == "1")
                {
                    break;
                }
                if (nomesPessoas.Contains(nome))
                {
                    Console.WriteLine("Nome já cadastrado");
                }


                else
                {
                    nomesPessoas.Add(nome);
                }
                Console.Write("1 - para continuar; 2 - para sair: ");
                continuar = int.Parse(Console.ReadLine());
            } while (continuar == 1);
            nomesPessoas.Sort();
            foreach (var pessoa in nomesPessoas)
            {
                Console.WriteLine(pessoa);
            }




        }
    }
}
