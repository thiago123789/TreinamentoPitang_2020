using System;
namespace Pitang.Treinamento.ONS.Entities
{
    public class Curso : AuditEntity
    {
        public virtual Aluno Aluno { get; set; }

        public int IdAluno { get; set; }
    }


}

