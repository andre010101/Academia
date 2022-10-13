using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoExemplo.questao07
{
    internal class Elevador
    {
        private int terreo = 0;

        public Elevador(int terreo)
        {
            this.terreo = terreo;
        }

        public int AndarAtual { get; set; }
        public int TotalAndaresPredio { get; set; }

        public int CapacidadeElevador { get; set; }

        public int PessoasNoElevador { get; set; }

        public void IniciarElevador()
        {
            CapacidadeElevador = 5;
            TotalAndaresPredio = 10;
        }

        public void entra()
        {
            if (PessoasNoElevador < CapacidadeElevador)
            {
                PessoasNoElevador++;
                if (PessoasNoElevador == 5)
                {
                    Console.WriteLine($"elevador chegou no limite de pessoas ");

                }
            }
        }

        public void Sai()
        {
            if (PessoasNoElevador > 0)
            {
                PessoasNoElevador--;
            }
        }

        public void sobe()
        {
            if (AndarAtual < TotalAndaresPredio)
            {
                AndarAtual++;
                if (AndarAtual == 10)
                {
                    Console.WriteLine($"Voce esta no utimo andar");
                }
            }

        }

        public void desce()
        {
            if (AndarAtual > terreo)
            {
                AndarAtual--;
                if (AndarAtual == 0)
                {
                    Console.WriteLine("voce esta no terreo");
                }

            }


        }

        public void ApresentarAndar()
        {
            Console.WriteLine($"voce esta {AndarAtual}° andar  ");
        }

        public void ApresentarPessoasAndar()
        {
            Console.WriteLine($"A um total de {PessoasNoElevador} pessoas no elevador");
        }
    }
}
