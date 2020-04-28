using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pitang.Treinamento.ONS.Entities;

namespace Pitang.Treinamento.ONS.Repository.Impl.Mapping
{
    public class AlunoMapping : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder
                .HasMany(e => e.Cursos)
                .WithOne()
                .HasForeignKey(e => e.IdAluno);




        }
    }
}
