
//9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
//diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
//Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
//Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.

//Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
//menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
//150, avisá-lo que será necessário adicionar 2 unidades de insulina.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02.Exercicios
{
    internal class Exercicio09
    {

        public static void Ex09()
        {
            Console.WriteLine("Informe o primeiro valor do teste de glicemia");
            int test1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o primeiro valor do teste de glicemia");
            int test2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o primeiro valor do teste de glicemia");
            int test3 = int.Parse(Console.ReadLine());

            int mediaTest = (test1 + test2 + test3) / 3;




            if (mediaTest < 80 )
            {
                Console.WriteLine("Você precisa diminuir 2 unidades de insulina ");
            }
            if (mediaTest > 150)
            {
                Console.WriteLine("Você precisa adicionar 2 unidades de insulina ");
            }

            else if (test1 < 65 || test1 > 250 || test2 < 65 || test2 > 250 || test3 < 65 || test3 > 250)
            {
                Console.WriteLine("avisá-lo que corre risco de hipoglicemia");
            }
            else
            {
                Console.WriteLine("O seu indice etá certo");
            }

           
        }
    }
}
