//4.Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
//Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
//Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
//Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
//escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
//de votos em branco. 



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04.atividades
{
    internal class Exercicio04
    {
        public static void Ex04()
        {


            int  joao = 0, zeca = 0, branco = 0;
            string nome;

            do
            {
                

                Console.WriteLine("O nome do candidato");
                nome = (Console.ReadLine());
                if (nome == "joao")
                {
                    joao++;
                   
                }
                if (nome == "zeca")
                {
                   zeca++;

                }
                if (nome == "branco")
                {
                    branco++;
                 
                }

               
            }



            while (nome != "fim");

            Console.WriteLine($"nome {nome}  joao teve {joao}  zeca teve {zeca}  total de votos brancos {branco}");












        }
    }
}
