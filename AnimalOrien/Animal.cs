using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalOrien
{
    internal class Animal
    {

        private string nome;
        private string sexo;
        private string raca;

        public Animal(string nome, string sexo, string raca)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.raca = raca;
        }


        public void EmitirSom()
        {
            Console.WriteLine($"Som do {nome}");
        }

        public void Dormir()
        {
            Console.WriteLine($"O {nome} esta a dormir");
        }

        public void Caminhar()
        {
            Console.WriteLine($"O {nome} esta a camihar");
        }


    }
}
