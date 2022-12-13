using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoExemplo.questao08
{
    internal class ControleRemoto
    {
        public string aumentar { get; set; }

        public int diminuir { get; set; }

        public int numeroCanal { get; set; }

        public int trocar { get; set; }

        public void IniciaTv(int volumeMaximo, int volumeMinimo, int volumeAtual)
        {
            volumeMaximo = 20;
            volumeMinimo = 1;
            volumeAtual = 10;
        }

        public void aumentarVolume( int volumeAtual)
        {
            
            if (aumentar == "+")
            {
                volumeAtual++;
            }
        }


    }
}
