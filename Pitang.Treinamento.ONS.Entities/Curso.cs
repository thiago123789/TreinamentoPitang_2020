using System;
using System.Collections.Generic;

namespace Pitang.Treinamento.ONS.Entities
{
    public class Curso : AuditEntity
    {
        public virtual IList<CursoAluno> Aluno { get; set; }

        public int IdAluno { get; set; }
    }


}

