using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_exercicios_oo_lista_dicionario.txt.Ex02
{
    internal class Animal
    {

       
        private string tipo;
       private string nome;

        public Animal(string tipo, string nome)
        => (Tipo, Nome) = (tipo, nome);

        public Animal()
        {
            this.dog = dog;
            this.cat = cat;
            this.fish = fish;
        }

        public bool dog { get; set; }
        public bool cat { get; set; }

        public bool fish { get; set; }


        public string Tipo { get => tipo; set => tipo = value; }
        public string Nome { get => nome; set => nome = value; }

        public void ExibirDados()
        {

            Console.WriteLine($"O animal do {Tipo} co nome {Tipo} ");
        }
       
    }
}
