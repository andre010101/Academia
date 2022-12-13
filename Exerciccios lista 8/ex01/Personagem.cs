using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exerciccios_lista_8.ex01
{
    internal class Personagem
    {

        //public List<Personagem> personagens = new List<Personagem>();

        public Personagem(string nome, int poder)
        {
            _nome = nome;
            _poder = poder;
            personagens.Add(this);
        }
        public Personagem() { }

        public string _nome { get; set; }
        public int _poder { get; set; }


        public void Addpersonagens(string nome, int poder)
        {
            personagens.Add(new(nome, poder));
        }

        public void ExibirDados()

        {
            foreach (Personagem p in personagens)
            {
                Console.WriteLine($"o personagem {p._nome} com poder {p._poder}");
            }
        }


    }
}
