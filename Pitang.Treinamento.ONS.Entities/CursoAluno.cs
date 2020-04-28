using System;
namespace Pitang.Treinamento.ONS.Entities
{
    public class CursoAluno
    {
        public int Id { get; set; }

        public virtual Aluno Aluno { get; set; }
        public virtual Curso Curso { get; set; }

        public int AlunoId { get; set; }
        public int CursoId { get; set; }

        public CursoAluno()
        {
        }
    }
}
