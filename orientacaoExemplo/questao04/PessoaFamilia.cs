using orientacaoExemplo.aluguel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoExemplo.arvore
{
    internal class PessoaFamilia : Pessoa
    {
        public string avô { get; set; }
        public string avó { get; set; }
        public string pai { get; set; }
        public string mae { get; set; }
        public string irma1 { get; set; }

        public string irma2 { get; set; }

        public string irma3 { get; set; }

        public string eu { get; set; }


        public void ApresentarArvorePai()
        {
            Console.WriteLine( $"Arvore genealogica vó --{avó}-- vô --{avô}--- \n pai: {pai} casado {mae} \n" +
                $" filhos {irma1} --- {irma2} --{irma2}--{irma3} -- {eu} " );
        }
    }
}
