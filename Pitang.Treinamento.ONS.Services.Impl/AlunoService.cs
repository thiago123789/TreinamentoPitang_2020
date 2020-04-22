using System;
using System.Linq.Expressions;
using Pitang.Treinamento.ONS.Entities;
using Pitang.Treinamento.ONS.Repository.Contracts;

namespace Pitang.Treinamento.ONS.Services.Impl
{
    public class AlunoService
    {
        private readonly IAlunoRepository alunoRepository;
        
        public AlunoService(IAlunoRepository alunoRepository)
        {
            this.alunoRepository = alunoRepository;
        }

        public void MetodoTeste()
        {
            Expression<Func<Aluno, bool>> predicate = e => e.Nome.Contains("A");
            var alunos = alunoRepository.FindBy(predicate);
        }
    }
}
