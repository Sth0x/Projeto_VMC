﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Projeto_VMC.Models;

public class AlunoMapeamento : IEntityTypeConfiguration<Aluno>
{
    public void Configure(EntityTypeBuilder<Aluno> builder)
    {
        builder.ToTable("Aluno");

        builder.HasKey(t => t.Id);
        builder.Property(t => t.Matricula).HasColumnType("varchar(20)");
        builder.Property(t => t.Nome).HasColumnType("varchar(40)");
        builder.Property(t => t.Cpf).HasColumnType("varchar(14)");

    }
}