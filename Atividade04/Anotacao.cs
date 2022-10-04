//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Metrics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Atividade04
//{
//    internal class Anotacao
//    {

//int i;
//int[] b = new int[5];
//console.writeline("------ keitura dos valores: ------");
//for (i = 0; i < 5; i++)
//{
//    console.writeline("digite o valor " + i + ":");
//    b[i] = int.parse(console.readline());
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
//        int[] vetor = new int[10];
//        int i, menor, pos, posMenor, maior;
//            //laço para leitura dos elemntos
//            for (i= 0; i< 10; i++)
//            {
//                Console.WriteLine("digite o valor do elemento" + i);
//                vetor[i]= int.Parse(Console.ReadLine());
//    }
//    menor = vetor[0];//defino que o primeiro elemento é maior 
//            posMenor = 0;
//            for(i = 0; i< 10; i++)
//            {
//                if (vetor[i] < posMenor) 
//                {
//                    posMenor = vetor[i];
//                    posMenor = i;
//                }
//            }
//            


//Console.WriteLine("o menor elmento é :" + menor + " e está na posição " + pos);



//int[] vetor1 = new int[5];
//int i, UmTrez, QuatroOito, Oito, Zero;

//QuatroOito = 0;
//UmTrez = 0;
//Oito = 0;
//Zero = 0;

//for (i = 0; i < 5; i++)
//{
//    Console.WriteLine($" Digite quantidade de filhos ");
//    vetor1[i] = int.Parse(Console.ReadLine());

//    if (vetor1[i] <= 3 && vetor1[i] == 1)
//    {
//        UmTrez++;

//    }
//    if (vetor1[i] <= 7 && vetor1[i] >= 4)
//    {
//        QuatroOito++;

//    }
//    if (vetor1[i] >= 8)
//    {
//        Oito++;
//    }
//    else
//    {
//        Zero++;
//    }

//}
//Console.WriteLine($"total de  {UmTrez} pessoas tem entre 1 e 3 filhos {QuatroOito} {Oito} {Zero} ");
////    Console.WriteLine($"total de  pessoas tem entre 4 e 7 filhos");
//    Console.WriteLine($"total de   pessoas tem mais de 8 filhos");
//    Console.WriteLine($"total de   nao tem filhos");
//}
//}
