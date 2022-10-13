using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using orientacaoExemplo.aluguel;
using System.Runtime.Intrinsics.X86;
using orientacaoExemplo.arvore;
using orientacaoExemplo.questao05;
using orientacaoExemplo.questao06;
using System.Numerics;
using System.Reflection;
using orientacaoExemplo.questao07;

namespace orientacaoExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Apresentando Classes, objetos, métodos e orientação a objetos básica");
            /* Exemplo 1
             * Lampada l1 = new Lampada();
             bool retorno;
             l1.ligar();
             retorno = l1.estaLigada();
             Console.WriteLine("Status da Lampada: "+retorno);
             l1.desligar();
             retorno = l1.estaLigada();
             Console.WriteLine("Status da Lampada: " + retorno); */

            /* Exemplo 2
            Aviao a = new Aviao();
            a.marca = "AirBus";
            a.modelo = "A330";
            a.altitude = 10000;
            a.velocidade = 800;
            a.acelerar();
            a.descer();
            a.reduzir();
            a.subir();
            */
            //string ag;
            //int tp;
            //double val;
            //string c;
            //double s, d;
            //Console.WriteLine("Digite o número da agência: ");
            //ag = Console.ReadLine();
            //Console.WriteLine("Digite o número da conta: ");
            //c = Console.ReadLine();
            //Console.WriteLine("Digite o tipo da conta: 1 - para conta corrente\n 2 - para conta poupança");
            //tp = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor inicial a ser depositado na conta: ");
            //val = double.Parse(Console.ReadLine());


            //ContaBancaria conta = new ContaBancaria(ag, c, tp, val);

            //conta.exibirDados();
            //Console.WriteLine("Digite o valor do saque: ");
            //s = double.Parse(Console.ReadLine());
            //conta.sacar(s);
            //conta.consultarSaldo();
            //Console.WriteLine("Digite o valor do depósito: ");
            //d = double.Parse(Console.ReadLine());
            //conta.depositar(d);

            //string titulo,autor, editora;
            //int isbn;

            //Console.WriteLine("Digite o titulo do livro");
            //titulo = Console.ReadLine();

            //Console.WriteLine("Digite autor  do livro");
            //autor = Console.ReadLine();

            //Console.WriteLine("Digite a editora");
            //editora = Console.ReadLine();

            //Console.WriteLine("Digite o numero do  isbn");
            //isbn =int.Parse (Console.ReadLine());

            //Livro livro = new Livro(titulo, autor, editora, isbn);

            //livro.livrosCadastrados();

            //3 - Faça um programa para controlar o aluguel de carros. Deve ter as classes Carro, aluguel e cliente.
            //Pessoa pessoa = new Pessoa();

            //Console.WriteLine("digite o seu nome");
            //pessoa.nome = Console.ReadLine();


            //Console.WriteLine("digite o seu CPF");
            //pessoa.CPF = double.Parse(Console.ReadLine());


            //Console.WriteLine("digite o telefone");
            //pessoa.telefone = double.Parse(Console.ReadLine());




            //Carro carro = new Carro();
            //Console.WriteLine("Digite o modelo do carro");
            //carro.modelo = Console.ReadLine();

            //Console.WriteLine("Digite a placa do carro");
            //carro.placa = Console.ReadLine();

            //Console.WriteLine("Digite a cor do carro");
            //carro.cor = Console.ReadLine();



            //Aluguel aluguel = new Aluguel(50);

            //Console.WriteLine("Digite o numero de dias que o carro ficou alugado");
            //aluguel.dia=int.Parse(Console.ReadLine());

            //aluguel.ValorApagar();


            //pessoa.ApresentarPessoa();
            //carro.ApresentarCarro();
            //aluguel.ApresentarValor();


            //4 - Faça um programa que represente a arvore genealógica da tua familia.
            //    Para isso, uma classe Pessoa precisa ser indicar quem são seus pais, alem deinformações básicas sobre a pessoa.


            //PessoaFamilia familia = new PessoaFamilia();
            //Console.WriteLine("Digite o nome do seu avô ");
            //familia.avô = Console.ReadLine();

            //Console.WriteLine("Digite o nome da seu avó ");
            //familia.avó = Console.ReadLine();


            //Console.WriteLine("Digite o nome do seu  pai ");
            //familia.pai = Console.ReadLine();


            //Console.WriteLine("Digite o nome da sua mae ");
            //familia.mae= Console.ReadLine();

            //Console.WriteLine("Digite o nome do seu irmao(a) ");
            //familia.irma1 = Console.ReadLine();


            //Console.WriteLine("Digite o nome do seu irmao(a) ");
            //familia.irma2 = Console.ReadLine();

            //Console.WriteLine("Digite o nome do seu irmao(a)  ");
            //familia.irma3 = Console.ReadLine();

            //Console.WriteLine("Digite o seu  nome  ");
            //familia.eu = Console.ReadLine();

            //familia.ApresentarArvorePai();


            //5 - Identifique as classes     e implemente  um programa    para a   seguinte especificação:	 "O	supermercado	 vende	 diferentes	 tipos	 de	 produtos.	 Cada	 produto	 tem	 um	 preço	 e	 uma	quantidade	em	estoque.	Um	pedido	de	um	cliente	é	composto	de	itens,	onde	cada	item	especifica	o	produto	que	o	cliente	deseja	e	a	respectiva	quantidade. Esse	" +
            //    "pedido	pode	ser	pago" +
            //    "	em	dinheiro,	cheque	ou	cartão."


            //Produtos p = new Produtos();

            //Console.WriteLine($"Digite o nome do produto ");
            //p.nomeProduto = Console.ReadLine();

            //Console.WriteLine($"Digite o valor do produto ");
            //p.valorProduto = int.Parse(Console.ReadLine());


            //Console.WriteLine($"Digite a quantidade do produto ");
            //p.quantidadeProduto = int.Parse(Console.ReadLine());
            //p.SomarProdutos();
            //Console.WriteLine("Digite 1 para cartao -2 para cheque - 3 para dinheiro ");
            //p.formaPg = (Console.ReadLine());

            //p.ApresentarProdutos();
            //p.FormaDePagamento();



            //6 - Crie uma classe Agenda que pode armazenar 10 pessoas e que seja capaz de realizar as seguintes operações:
            //void armazenaPessoa(String nome, int idade, float altura);
            //void removePessoa(String nome);
            //Pessoa buscaPessoa(String nome); // retorna a pessoa com o nome informado
            //void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda

            /*
            int op;

            Agenda ag = new Agenda();

            string nome;
            int idade;
            float altura;

            Pessoa1 consulta = null;
            Pessoa1 remove = null;
            while (true)
            {
                Console.WriteLine("Digite 1 para cadastrar pessoa\nDigite 2 para buscar as informações \nDigite 3 para apagar pessoa\nDigite 4 para sair");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine("Digite o nome da pessoa: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite o idade da pessoa: ");
                    idade =int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a altura da pessoa: ");
                    altura = float.Parse(Console.ReadLine());
                    ag.ArmazenaPessoa(nome, idade, altura);
                   
                    Console.Clear();
                    ag.MostraPessoas();
                }
                if (op == 2)
                {
                    Console.WriteLine("Digite o nome da pessoa que deseja consultar: ");
                    nome = Console.ReadLine();
                    consulta = ag.BuscaPessoa(nome);
                    if (consulta != null)
                    {
                        Console.WriteLine("PESSOA ENCONTRADA! NOME: " + consulta.nome + " idade " + consulta.idade);

                    }
                    else
                    {
                        Console.WriteLine("Pessoa nao encotrada");
                    }
                }
                if (op == 3)
                {
                    Console.WriteLine("Digite o nome da pessoa que sairá: ");
                     nome= Console.ReadLine();
                     ag.RemovePessoa(nome);
                }
                if (op == 4)
                {
                    break;
                }
            }

            */

            //7 - Crie uma classe denominada Elevador para armazenar as informações de um elevador dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), total de andares no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão presentes nele. A classe deve também disponibilizar os seguintes métodos:
            //Inicializa: que deve receber como parâmetros a capacidade do elevador e o total de andares no prédio (os elevadores sempre começam no térreo e vazio);
            //Entra: para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver espaço);
            //Sai: para remover uma pessoa do elevador (só deve remover se houver alguém dentro dele);
            //Sobe: para subir um andar(não deve subir se já estiver no último andar);
            //Desce: para descer um andar(não deve descer se já estiver no térreo);
            //Encapsular todos os atributos da classe (criar os métodos set e get).



            Elevador elevador = new Elevador(0);
            elevador.IniciarElevador();
            elevador.sobe();



            elevador.entra();

            elevador.ApresentarAndar();
            elevador.ApresentarPessoasAndar();
        }
    }
}