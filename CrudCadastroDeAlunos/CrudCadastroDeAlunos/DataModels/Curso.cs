namespace CrudCadastroDeAlunos.DataModels
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string nome { get; set; }
        public int AlunoId { get; set; }
       
        public virtual List<Matricula> matricula { get; set; }

    }
}
