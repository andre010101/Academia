


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_exercicios_oo_lista_dicionario.txt
{
    internal class Personagem
    {
       


        public string Nome { get; set; }
        public int Poder { get; set; }



     public void ExibirDados()
        {
            Console.WriteLine($"o {Nome}  {Poder} ");
        }
    }
}
