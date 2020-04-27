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

        public async  Task<T> AddAsync(T entity)
        {
            //await _context.Set<T>().AddAsync(entity);
            await _entities.AddAsync(entity);
            return entity;
        }

        public T Delete(T entity)
        {
            entity.IsDeleted = true;
            _entities.Attach(entity).State = EntityState.Modified;
            return entity;
        }

        public IEnumerable<T> FindAll()
        {
            throw new NotImplementedException();
        }

        //Lazy loading <-
        //Eager loading
        private IQueryable<T> Query(bool eager = false)
        {
            var query = _entities.AsQueryable();
            if (eager)
            {
                foreach (var property in _context.Model.FindEntityType(typeof(T)).GetNavigations())
                {
                    query = query.Include(property.Name);
                }
            }
            return query;
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate, bool eager = false)
        {
            var query = Query(eager);

            query = query.Where(predicate);

            return query.ToList();
        }

        public T UnDelete(T entity)
        {
            entity.IsDeleted = false;
            _entities.Attach(entity).State = EntityState.Modified;
            return entity; 
        }

        public T Update(T entity)
        {
            _entities.Attach(entity).State = EntityState.Modified;
            return entity;
        }
    }
}
