using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoExemplo.questao08
{
    internal class Televisao:ControleRemoto
    {
        private int disney =10;
        private int SBT = 5;
        private int globo = 3;

        public Televisao(int disney, int sBT, int globo)
        {
            this.disney = disney;
            SBT = sBT;
            this.globo = globo;
        }


    }
}
