
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrudCadastroDeAlunos.DataModels
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string nome { get; set; }
        public virtual List<Matricula> matricula { get; set; }


    }
}
