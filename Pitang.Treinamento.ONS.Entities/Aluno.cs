using System;
using System.Collections.Generic;

namespace Pitang.Treinamento.ONS.Entities
{
    public class Aluno : AuditEntity
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Cidade { get; set; }

        public IList<Curso> Cursos { get; set; }

        public Aluno()
        {
            this.Cursos = new List<Curso>();
        }
    }
}
