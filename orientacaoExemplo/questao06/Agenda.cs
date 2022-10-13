using orientacaoExemplo.aluguel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoExemplo.questao06
{
    internal class Agenda
    {
        public List<Pessoa1> pessoa = new List<Pessoa1>();

        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            Pessoa1 pe = new Pessoa1(nome, idade, altura);
            pessoa.Add(pe);
        }

        public Pessoa1 BuscaPessoa(string nome)
        {
            Pessoa1 r = null;
            foreach (Pessoa1 pe in pessoa)
            {
                if (pe.nome.Equals(nome))
                {
                    r = pe;
                }
            }
            return r;
        }
        public void MostraPessoas()
        {


            foreach (Pessoa1 pe in pessoa)
            {
                Console.WriteLine("Pessoa: " + pe.nome + " idade " + pe.idade + " altura: " + pe.altura);
            }

        }

        public void RemovePessoa(String nome)
        {
            foreach (Pessoa1 pe in pessoa)
            {
                if (pe.nome.Equals(nome))
                {
                    pessoa.Remove(pe);
                    Console.WriteLine("nome removido da lista");
                }
            }

        }    } }
   
        