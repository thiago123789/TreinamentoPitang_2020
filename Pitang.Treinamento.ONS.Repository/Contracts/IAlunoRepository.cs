using System;
using System.Collections.Generic;
using Pitang.Treinamento.ONS.Entities;

namespace Pitang.Treinamento.ONS.Repository.Contracts
{
    public interface IAlunoRepository : IRepository<Aluno>
    {
        IList<Aluno> FiltrarAlunosPorCurso(IList<int> cursoIDs);
    }
}
