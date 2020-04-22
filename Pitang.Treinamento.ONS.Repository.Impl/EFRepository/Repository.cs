using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pitang.Treinamento.ONS.Entities;
using Pitang.Treinamento.ONS.Repository.Impl.EFRepository;

namespace Pitang.Treinamento.ONS.Repository.Contracts
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected TreinamentoDbContext _context;
        protected DbSet<T> _entities;

        public Repository(TreinamentoDbContext dbContext)
        {
            _context = dbContext;
            _entities = _context.Set<T>();
        }

        public T Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            var query = _entities.AsQueryable();

            query = query.Where(predicate);

            return query.ToList();
        }

        public void UnDelete(T id)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
