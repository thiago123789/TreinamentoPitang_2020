using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pitang.Treinamento.ONS.Entities;

namespace Pitang.Treinamento.ONS.Repository.Impl.EFRepository
{
    public class TreinamentoDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public TreinamentoDbContext(DbContextOptions<TreinamentoDbContext> dbContext) : base(dbContext)
        {

        }

        public TreinamentoDbContext()
        {
        }

        public override int SaveChanges()
        {
            Audit();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            Audit();
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TreinamentoDbContext).Assembly);
        }

        public void Audit()
        {
            var entries = ChangeTracker.Entries()
                .Where(entry => entry.Entity is AuditEntity &&
                            (entry.State == EntityState.Added ||
                            entry.State == EntityState.Deleted ||
                            entry.State == EntityState.Modified));

            foreach (var entry in entries)
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        ((AuditEntity)entry.Entity).CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Deleted:
                        ((AuditEntity)entry.Entity).LastUpdateDate = DateTime.Now;
                        ((AuditEntity)entry.Entity).IsDeleted = true;
                        break;
                    case EntityState.Modified:
                        ((AuditEntity)entry.Entity).LastUpdateDate = DateTime.Now;
                        break;
                }
            }

        }
    }
}
