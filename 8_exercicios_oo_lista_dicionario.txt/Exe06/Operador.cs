using _8_exercicios_oo_lista_dicionario.txt.Exe06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_exercicios_oo_lista_dicionario.txt.Exe06
{
    class Operador : Funcionario
    {
        public Operador() { }
        public Operador(string nome, string depto, string dataCriacao, string rg, double salario, bool ativo) : base(nome, depto, dataCriacao, rg, salario, ativo) { }

        public override void ExecutaTrabalho()
        {
            throw new NotImplementedException();
        }
    }
}
