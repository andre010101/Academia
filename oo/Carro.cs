using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oo
{
    internal class Carro
    {
       
        public string modelo;
        public string cor;
        public string placa;

        public string Modelo { get => modelo; set => modelo = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Placa { get => placa; set => placa = value; }
    }
}
