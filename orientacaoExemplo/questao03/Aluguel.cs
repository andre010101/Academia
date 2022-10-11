using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoExemplo.aluguel
{
    internal class Aluguel
    {

        private int valorDiaria = 50;
        public Aluguel(int valorDiaria)
        {
            this.valorDiaria = valorDiaria;
        }

        public int TotalAluguel { get; set; }
        public int dia { get; set; }





        public void ValorApagar()
        {
            TotalAluguel = dia * valorDiaria;
        }

        public void ApresentarValor()
        {
            Console.WriteLine($"O valor total a pagar é de {TotalAluguel} Reais ");
        }
    }
}

