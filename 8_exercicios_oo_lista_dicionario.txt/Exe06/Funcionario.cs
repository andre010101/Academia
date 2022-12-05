using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using _8_exercicios_oo_lista_dicionario.txt.Exe06;
namespace _8_exercicios_oo_lista_dicionario.txt.Exe06
{
    abstract class Funcionario
    {

        //ter o nome do funcionário, o departamento onde trabalha, seu salário (double), a data de entrada no banco (String),
        //seu RG (String) e um valor booleano que indique se o
        //funcionário ainda está ativa na empresa no momento ou se já foi mandado embora.

        private string _nome, _depto, _dataCriacao, _rg;
            private double _salario;
            private bool _ativo;



            public Funcionario() { }
            public Funcionario(string nome, string depto, string dataCriacao, string rg, double salario, bool ativo)
            {
                this._nome = nome;
                this._depto = depto;
                this._dataCriacao = dataCriacao;
                this._rg = rg;
                this._salario = salario;
                this._ativo = true;
            }
            public abstract void ExecutaTrabalho();
            public void Bonifica(double acrescimo)
            {
                this._salario += acrescimo;
                Console.WriteLine("Salário aumentado em " + acrescimo);
            }
            public void Demite()
            {
                this._ativo = false;
                Console.WriteLine("Funcionário demitido!");
            }
            public void MostraDados()
            {
                Console.WriteLine("Nome: " + _nome);
                Console.WriteLine("Departamento: " + _depto);
                Console.WriteLine("Data contratação: " + _dataCriacao);
                Console.WriteLine("RG: " + _rg);
                Console.WriteLine("Salário: " + _salario);
                Console.WriteLine("Status: " + (_ativo == true ? "Ativo" : "Demitido"));
            }



            public string Nome { get => _nome; set => _nome = value; }
            public string Depto { get => _depto; set => _depto = value; }
            public string DataCriacao { get => _dataCriacao; set => _dataCriacao = value; }
            public string Rg { get => _rg; set => _rg = value; }
            public double Salario { get => _salario; set => _salario = value; }
            public bool Ativo { get => _ativo; set => _ativo = value; }
        }
    }














