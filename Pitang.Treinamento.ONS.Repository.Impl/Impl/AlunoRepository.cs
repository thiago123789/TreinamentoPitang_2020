using System;
using System.Collections.Generic;
using Pitang.Treinamento.ONS.Entities;
using Pitang.Treinamento.ONS.Repository.Contracts;
using Pitang.Treinamento.ONS.Repository.Impl.EFRepository;

namespace Pitang.Treinamento.ONS.Repository.Impl.Impl
{
    public class AlunoRepository : Repository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(TreinamentoDbContext dbContext): base(dbContext)
        {
        }

        public IList<Aluno> FiltrarAlunosPorCurso(IList<int> cursoIDs)
        {
            throw new NotImplementedException();
        }
    }
}
