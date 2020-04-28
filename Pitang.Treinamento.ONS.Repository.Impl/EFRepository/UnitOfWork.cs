using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Pitang.Treinamento.ONS.Repository.Contracts;
using Pitang.Treinamento.ONS.Repository.Impl.Impl;

namespace Pitang.Treinamento.ONS.Repository.Impl.EFRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TreinamentoDbContext _treinamentoDbContext;
        private readonly ILogger _logger;

        private IAlunoRepository _alunoRepository;


        #region Repositories

        public IAlunoRepository alunoRepository =>
            _alunoRepository ?? (_alunoRepository = new AlunoRepository(_treinamentoDbContext));





        #endregion

        public UnitOfWork(TreinamentoDbContext treinamentoDbContext, ILogger<UnitOfWork> logger)
        {
            _treinamentoDbContext = treinamentoDbContext;
            _logger = logger;
            ForceBeginTransaction();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void ForceBeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void RollbackTransaction()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void SetIsolationLevel(IsolationLevel isolationLevel)
        {
            throw new NotImplementedException();
        }
    }
}
