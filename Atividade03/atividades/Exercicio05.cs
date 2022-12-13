//5.Modifique o programa em VS anterior para aceitar votos nulos 
//(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
//Ao final, informe o nome do candidato vencedor, o número de votos nulos 
//e o número de pessoas que votaram.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03.atividades
{
    internal class Exercicio05
    {
        public static void EX05()
        {
            int joao = 0, zeca = 0, branco = 0, nulo = 0, totalVotos;
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
                if (nome == "nulo")
                {
                    nulo++;

                }


            }
            

            while (nome != "fim");

            totalVotos = joao + zeca + branco + nulo;

            if (joao > zeca )
            {
                Console.WriteLine($"o joao teve mais votos{joao}");
            }
            if (zeca > joao)
            {
                Console.WriteLine($"o zeca teve mais votos{zeca}");
            }

            Console.WriteLine($"nome {nome}  joao teve {joao}  zeca teve {zeca}  total de votos brancos {branco}  total de votos {nulo}");
            Console.WriteLine($"número de pessoas que votaram {totalVotos}");


        }

    }
}
