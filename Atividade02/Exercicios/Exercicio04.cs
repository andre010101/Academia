//4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
//Mostrar na tela qual dos professores tem o maior salário total.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02.Exercicios
{
    internal class Exercicio04
    {
        public static void Ex04()
        {
            int Professor1, Professor2, HorasExtra1, HorasExtra2, AulasDadas, HoraRecebida,SalarioProfessor1, SalarioProfessor2,ValorHora,SalarioSemHoraExtra, NumeroDeAulasProfessor1, NumeroDeAulasProfessor2;

            ValorHora = 20;
            SalarioSemHoraExtra = 1900;

            Console.WriteLine("Digite o numero de horas extras feitas Professor1");//numero de horas feitas
            HorasExtra1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de aulas feitas professor1");
            NumeroDeAulasProfessor1 = int.Parse(Console.ReadLine());//numero de aulas
            Console.WriteLine($"O professor01 fez {NumeroDeAulasProfessor1} aulas");



            Console.WriteLine("Digite o numero de horas extras feitas professor2 "); //numero de horas feitas
            HorasExtra2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de aulas feitas professor2");//numero de aulas
            NumeroDeAulasProfessor2 = int.Parse(Console.ReadLine());


            Console.WriteLine($"O professor01 fez {NumeroDeAulasProfessor1} aulas");//numero de aulas imprime
            Console.WriteLine($"O professor02 fez {NumeroDeAulasProfessor2} aulas");//numero de aulas imprime
            SalarioProfessor1 = (HorasExtra1 * ValorHora) + SalarioSemHoraExtra;
            Console.WriteLine($"O salario do Professor1 foi de {SalarioProfessor1}");//imprime o salario
            SalarioProfessor2 = (HorasExtra2 * ValorHora) + SalarioSemHoraExtra;
            Console.WriteLine($"O salario do Professor2 foi de {SalarioProfessor2}");//imprime o salario


            if (SalarioProfessor1 > SalarioProfessor2 )
            {
                Console.WriteLine("O salario do professor1 é maior");
            }
            if (SalarioProfessor2 > SalarioProfessor1)
            {
                Console.WriteLine("O salario do professor2 é maior");
            }
        }

    }
}
