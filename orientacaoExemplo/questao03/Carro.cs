using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoExemplo.aluguel
{
    internal class Carro
    {

        public string modelo { get; set; }
        public string cor { get; set; }

        public string placa { get; set; }


        public void ApresentarCarro()
        {
            Console.WriteLine($"O carro do modelo {modelo} cor: {cor} placa: {placa}");
        }
    }
}
