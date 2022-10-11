using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoExemplo.livro
{
    internal class Livro
    {
        string titulo;
        string editora;
        string autor;
        int isbn;

        public Livro(string titulo, string editora, string autor, int isbn)
        {
            this.titulo = titulo;
            this.editora = editora;
            this.autor = autor;
            this.isbn = isbn;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Editora { get => editora; set => editora = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Isbn { get => isbn; set => isbn = value; }


        public void livrosCadastrados()
        {
            Console.WriteLine($"Titulo do livro {titulo}");
            Console.WriteLine($"Editora do livro {editora}");
            Console.WriteLine($"autor do livro {autor}");
            Console.WriteLine($"isbn do livro {isbn}");
        }
    }
}
