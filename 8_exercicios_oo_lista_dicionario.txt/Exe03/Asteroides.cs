using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_exercicios_oo_lista_dicionario.txt.Exe03
{
    internal class Asteroides
    {
        private int _posicaoX;
        private int _posicaoY;
        private int _tamanhoAsteroide;
        private int velocidadeAsteroide;
        private int energia;

        public Asteroides()
        {
        }

        public Asteroides(int posicaoX, int posicaoY)
        {
            PosicaoX = posicaoX;
            PosicaoY = posicaoY;
        }

        public Asteroides(int posicaoX, int posicaoY, int tamanhoAsteroide, int velocidadeAsteroide, int energia)
        {
            _posicaoX = posicaoX;
            _posicaoY = posicaoY;
            _tamanhoAsteroide = tamanhoAsteroide;
            this.velocidadeAsteroide = velocidadeAsteroide;
            this.energia = energia;
        }

        public bool _tamanho { get; set; }

        public Asteroides(bool tamanho)
        {
            _tamanho = tamanho;
         
        }
        public void tamanho1()
        {
            if (TamanhoAsteroide >= 1 || TamanhoAsteroide <= 10)
            {
                _tamanho = true;
            }
        }

        public int PosicaoX { get => _posicaoX; set => _posicaoX = value; }
        public int PosicaoY { get => _posicaoY; set => _posicaoY = value; }
        public int TamanhoAsteroide { get => _tamanhoAsteroide; set => _tamanhoAsteroide = value; }
        public int VelocidadeAsteroide { get => velocidadeAsteroide; set => velocidadeAsteroide = value; }
        public int Energia { get => energia; set => energia = value; }


        public void MostrarAsteroides()
        {
            Console.WriteLine($"o asteroide de tamanho {TamanhoAsteroide} está na posição {PosicaoX}X e na posição {PosicaoY}Y  com a velocidade de {VelocidadeAsteroide} e sua enegia é de {Energia}");
        }



    }
}
