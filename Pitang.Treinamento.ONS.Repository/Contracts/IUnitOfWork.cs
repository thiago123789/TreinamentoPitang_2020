using System;
using System.Data;
using System.Threading.Tasks;

namespace Pitang.Treinamento.ONS.Repository.Contracts
{
    public interface IUnitOfWork
    {

        #region Repositories

        public IAlunoRepository alunoRepository { get; }

        #endregion

        void ForceBeginTransaction();
        Task CommitAsync();
        void Commit();
        int SaveChanges();
        Task<int> SaveChangesAsync();
        void SetIsolationLevel(IsolationLevel isolationLevel);
        void Dispose();
        void RollbackTransaction();
    }
}
