//12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
//número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
//R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
//armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
//No final do processamento, exibir o salário total e o salário excedente do operário.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Atividade02.Exercicios
{
    internal class Exercicio12
    {
        public static void Ex12()
        {
            int codigo;
            int numeroHoras;
            int salario=0;
            int extra = 0;
            int salarioExtra=0;

            Console.WriteLine("Digite o codigo do Funcionario");
            codigo = int.Parse(Console.ReadLine());

            do { 
            Console.WriteLine("Digite o numero de horas");
            numeroHoras = int.Parse(Console.ReadLine());
                if (numeroHoras >= 50 )
                {
                    extra += numeroHoras;
                    
                }
                else
                {
                    extra += 0;
                }
            }while (numeroHoras < 0);
            if (extra >= 50)
            {
                extra = +20;
                salarioExtra = numeroHoras * 10 + extra;
                Console.WriteLine($"o do funcionario {codigo} - salario é de {salarioExtra} ");
            }
            else
            {
                salario = numeroHoras * 10;



                Console.WriteLine($"o do funcionario {codigo} - salario é de {salario} ");
            }
            
        }
    }
}
