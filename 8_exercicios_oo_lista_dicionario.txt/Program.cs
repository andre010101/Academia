using _8_exercicios_oo_lista_dicionario.txt.Ex02;
using _8_exercicios_oo_lista_dicionario.txt.Exe03;
using _8_exercicios_oo_lista_dicionario.txt.Exe06;

using System.Diagnostics;
using System.Numerics;

namespace _8_exercicios_oo_lista_dicionario.txt
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //Personagem p = new Personagem();
            //Console.WriteLine("digite o nome");
            //p.Nome = Console.ReadLine();



            //p.ExibirDados();


            //List<Animal> animalList = new(5);
            //Animal animal = new Animal();

            //int op;
            //int gatos= 0;
            //int cachorros= 0;
            //int peixes = 0;
            //while (true)
            //{
            //    Console.WriteLine("Digite 1 para cadastrar o tipo do animal e o nome \nDigite 2 para sair");
            //    op = int.Parse(Console.ReadLine());
            //    if (op == 1)
            //    {
            //        do
            //        {
            //            for (int i = 0; i < 5; i++)
            //            {
            //                Console.WriteLine("Digite tipo do animal ");
            //                animal.Tipo = Console.ReadLine();

            //                Console.WriteLine("Digite o nome do seu animal");
            //                animal.Nome = Console.ReadLine();
            //                if (animal.Tipo == "cachorro")
            //                {
            //                    cachorros++;
            //                    animal.dog = true;
            //                    animalList.Add(new Animal(animal.Nome ?? "Animal", animal.Tipo));
            //                }
            //                if (animal.Tipo == "gato")
            //                {
            //                    gatos++;

            //                    animalList.Add(new Animal(animal.Nome ?? "Animal", animal.Tipo));
            //                    animal.cat = true;
            //                }
            //                if (animal.Tipo == "peixe")
            //                {
            //                    peixes++;
            //                    animalList.Add(new Animal(animal.Nome ?? "Animal", animal.Tipo));
            //                    animal.fish = true;
            //                }


            //            }



            //        } while (!animal.cat && !animal.fish && !animal.dog);


            //    }

            //    if (op == 2)
            //    {
            //        break;
            //    }
            //}


            //Console.WriteLine("Lista Ordenada por tipo");

            //animalList.ForEach(delegate (Animal p)
            //{
            //    Console.WriteLine(String.Format("{0} {1}", p.Tipo, p.Nome));
            //});

            //Console.WriteLine($"Numero de gatos {gatos}\n Numero de cachorros {cachorros}\n Numero de Peixes {peixes}");

            //List<Asteroide> lista_asteroide = new List<Asteroide>();
            //Random random = new Random();

            //for (int i = 0; i < 50; i++)
            //{
            //    Asteroide asteroide = new Asteroide();
            //    asteroide.Posicao_x = random.Next(0, 100);
            //    asteroide.Posicao_y = random.Next(0, 100);
            //    asteroide.Tamanho = random.Next(1, 10);
            //    asteroide.Velocidade = random.Next(1, 5);
            //    asteroide.Energia = random.Next(1, 5);
            //    lista_asteroide.Add(asteroide);
            //}


            //foreach (Asteroide i in lista_asteroide)
            //{
            //    Console.WriteLine("Asteroide");
            //    Console.WriteLine(i.Posicao_x + " " + i.Posicao_y + " " + i.Tamanho + " " + i.Velocidade + " " + i.Energia);

            //}




            //List<Asteroides> aste = new(3);
            //Asteroides a = new Asteroides();
            //do { 
            //Console.WriteLine("digite o tamanho do asteroide");
            //a.TamanhoAsteroide=int.Parse(Console.ReadLine());
            //    if (a._tamanho)
            //    {
            //        aste.Add(a);
            //    }
            //}while(!a._tamanho);

            //a.MostrarAsteroides();
            //foreach (delegate (animal p)
            //{
            //    console.writeline(string.format("{0} {1}", p.tipo, p.nome));
            //}) ;


            List<Funcionario> listaFuncionario = new List<Funcionario>();//lista dos funcionarios
            Funcionario f = new Gerente(), funcionarioBusca = new Gerente();//lista gerente
            string nome, depto, rg, nomeBusca = "";
            int op;
            double salario, aumento;
            DateTime dataCriacao = DateTime.Today;
            string data = dataCriacao.ToShortDateString();
            while (true)
            {
                Console.WriteLine("Digite 1 para cadastrar, 2 aumentar salário, 3 para demitir" +
                    " 4 para mostrar os dados e 5 para sair.");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Qual cargo do funcionário? 1 = Gerente, 2 = Operador");
                        int cargo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o nome do funcionário");
                        nome = Console.ReadLine();
                        Console.WriteLine("Digite o departamento do funcionário");
                        depto = Console.ReadLine();
                        Console.WriteLine("Digite o RG do funcionário");
                        rg = Console.ReadLine();
                        Console.WriteLine("Digite o salário do funcionário");
                        salario = float.Parse(Console.ReadLine());
                        if (cargo == 1)
                        {
                            f = new Gerente(nome, depto, data, rg, salario, true);
                        }
                        else if (cargo == 2)
                        {
                            Operador operador = new Operador(nome, depto, data, rg, salario, true);
                            f = operador;
                        }
                        listaFuncionario.Add(f);
                        break;
                    case 2:
                        Console.WriteLine("Digite o nome do funcionário que deseja aumentar o salário:");
                        nomeBusca = Console.ReadLine();
                        funcionarioBusca = listaFuncionario.Find(delegate (Funcionario f) { return f.Nome == nomeBusca; });
                        if (funcionarioBusca == null)
                        {
                            Console.WriteLine("Funcionário não encontrado");
                            break;
                        }
                        Console.WriteLine("Em quanto deseja aumentar o salário? ");
                        aumento = int.Parse(Console.ReadLine());
                        funcionarioBusca.Bonifica(aumento);
                        break;
                    case 3:
                        Console.WriteLine("Digite o nome do funcionário que deseja demitir:");
                        nomeBusca = Console.ReadLine();
                        funcionarioBusca = listaFuncionario.Find(delegate (Funcionario f) { return f.Nome == nomeBusca; });
                        if (funcionarioBusca == null)
                        {
                            Console.WriteLine("Funcionário não encontrado");
                            break;
                        }
                        funcionarioBusca.Demite();
                        break;
                    case 4:
                        Console.WriteLine("------------");
                        foreach (Funcionario funcio in listaFuncionario)
                        {
                            funcio.MostraDados();
                            funcio.ExecutaTrabalho();
                            Console.WriteLine("------------");
                        }
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente:");
                        break;
                }
            }
        }
    }
}