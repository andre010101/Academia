using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade09___arquivos.Ex03
{
    internal class Figurinha
    {
        public string CodigoFigurinha { get; set; }
        public string Selecao { get; set; }
        public string NomeJogador { get; set; }

        public Figurinha(string codigo, string selecao, string jogador)
        {
            CodigoFigurinha = codigo;
            Selecao = selecao;
            NomeJogador = jogador;
        }
    }
}
