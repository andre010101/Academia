using Exerciccios_lista_8.exe02;
using System.Security.Cryptography.X509Certificates;

namespace Exerciccios_lista_8
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //List<Personagem> personagem = new List<Personagem>();
            ////Personagem personagem = new Personagem("andre", 8);
            //for (int i = 1; i < 3; i++)
            //{
            //    Console.WriteLine("digite o nome do personagem");
            //    string nome = Convert.ToString(Console.ReadLine());

            //    Console.WriteLine("digite a força do personagem");
            //    int poder = int.Parse(Console.ReadLine());

            //    personagem.Addpersonagens(nome, poder);


            List<Animal> animalList = new List<Animal>();
            Animal animal = new Animal();
           
            for (int i = 0; i < 3; i++)
            {
                do
                {
                    Console.WriteLine($"Digite o tipo do animal");
                    animal.Tipo = Console.ReadLine();

                    if (animal.Tipo == "cachorro" || animal.Tipo == "gato" || animal.Tipo == "peixe")
                    {

                    }

                } while (animal.Tipo != "cachorro" || animal.Tipo != "gato" || animal.Tipo != "peixe");
            }

            Console.WriteLine("Lista Ordenada por Nome");
            animalList.Sort(delegate (Animal p1, Animal p2)
            {
                return p1.Tipo.CompareTo(p2.Tipo);
            });
            animalList.ForEach(delegate (Animal p)
            {
                Console.WriteLine(String.Format("{0} {1}", p.Tipo, p.Nome));
            });



        }


    }
}