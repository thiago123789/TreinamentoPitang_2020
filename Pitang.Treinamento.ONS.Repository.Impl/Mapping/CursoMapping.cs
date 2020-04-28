using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pitang.Treinamento.ONS.Entities;

namespace Pitang.Treinamento.ONS.Repository.Impl.Mapping
{
    public class CursoMapping : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder
                .HasOne(e => e.Aluno)
                .WithMany(e => e.Cursos);

        }
    }
}
