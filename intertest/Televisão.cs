using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intertest
{
    internal class Televisão : Eletronico
    {
        public void Desligar()
        {
            throw new NotImplementedException();
        }

        public void Ligar()
        {
            throw new NotImplementedException();
        }

        public bool Ligado
        {
            get => _ligado;
            set => _ligado = value;
        }

        public void Desligar()
        {
            _ligado = true;
        }
    }
}
