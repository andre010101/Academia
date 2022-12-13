using System.Diagnostics;
using System.Drawing;

namespace oo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Cliente cliente = new Cliente();
            //Console.WriteLine("Digite o seu nome");
            //cliente.nome = Console.ReadLine();

            //Console.WriteLine("Digite o seu Cpf");
            //cliente.cpf = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o seu telefone");
            //cliente.telefone = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a sua idade");
            //cliente.idade = int.Parse(Console.ReadLine());


            Carro carro = new Carro();

            //Console.WriteLine("Digite o modelo do carro");
            //carro.modelo = (Console.ReadLine());

            //Console.WriteLine("Digite a placa");
            //carro.placa = (Console.ReadLine());

            //Console.WriteLine("Digite a cor");
            //carro.Cor = (Console.ReadLine());




            int t3;
            int dias=0;
            int valor=0 ;
            Aluguel aluguel = new Aluguel( dias, valor,carro,cliente);
            Console.WriteLine("digite o numero de dias");
            t3.setValorTotal = int.Parse(Console.ReadLine());
            
           








        }
    }

}





























