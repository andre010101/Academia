namespace CrudCadastroDeAlunos.DataModels
{
    public class Matricula
    {
        public int MatriculaId { get; set; }
        public int numero { get; set; }
        public int Alunoid { get; set; }
        public virtual Aluno aluno { get; set; }

        public int CursoId { get; set; }
        public virtual Curso curso { get; set; }
    }
}
