namespace vetoresTeste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i;
            //int[] b = new int[5];
            //Console.WriteLine("------ keitura dos valores: ------");
            //for (i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("digite o valor " + i + ":");
            //    b[i] = int.Parse(Console.ReadLine());
            //}

            //for (i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("valor indice" + i + " é igual a " + b[i]);
            //}

            //int i;
            //string[] carros = new string[5];
            //Console.WriteLine("------ keitura dos valores: ------");
            //for (i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("digite o valor " + i + ":");
            //    carros[i] = (Console.ReadLine());
            //}

            //for (i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("valor indice" + i + " é igual a " + carros[i]);
            //}


            //double[] notas = new double[50];
            //double media;
            //int i;

            //Console.WriteLine("------ keitura dos valores: ------");
            //for (i = 0; i < 50; i++)
            //{
            //    Console.WriteLine("digite a nota do aluno " + i + ":");
            //    notas[i] =double.Parse(Console.ReadLine());
            //}
            //media = 0;
            //Console.WriteLine("---calclulo da media sendo feito");
            //for (i = 0; i < 50; i++)
            //{
            //   media += notas[i];
            //}
            //media = media / 50;
            //Console.WriteLine("--mostra a media ");
            //Console.WriteLine("A media de notas é igual " + media );

            //int[] idade = new int[40];
            //int i, conta=0;

            // Console.WriteLine("------ informe a idade dos alunos da truma------");
            // for (i = 0; i < 40; i++)
            // {
            //     idade[i] = int.Parse(Console.ReadLine());
            //     if (idade[i] >= 18)
            //     {
            //         conta++;
            //     }
            // }

            // Console.WriteLine("Existem " +conta+"alusnos com idade maior ou igual a 18 anos ");
            // for (i = 0; i < 50; i++)
            // {
            //     if (idade[i] >= 18)
            //     {
            //         Console.WriteLine("aluno" + i + "tem " + idade[i] + "anos");
            //     }
            // }
            int[] vetor = new int[10];
            int i, menor, pos, posMenor, maior;
            //laço para leitura dos elemntos
            for (i= 0; i < 10; i++)
            {
                Console.WriteLine("digite o valor do elemento" + i);
                vetor[i]= int.Parse(Console.ReadLine());
            }
            menor = vetor[0];//defino que o primeiro elemento é maior 
            posMenor = 0;
            for(i = 0; i < 10; i++)
            {
                if (vetor[i] < posMenor) 
                {
                    menor = vetor[i];
                    posMenor = i;
                }
            }
            maior = vetor[0];//defino que o primeiro elemento é maior 
            pos = 0;
            for (i = 0; i > 10; i++)
            {
                if (vetor[i] > menor)
                {
                    maior = vetor[i];
                    pos = i;
                }
            }

            Console.WriteLine("o menor elmento é :" + menor + " e está na posição " + pos);
        }
    }
}