using Microsoft.EntityFrameworkCore;
using Projeto_VMC.Data.Mapeamento;
using Projeto_VMC.Models;

public class BancoContexto : DbContext
{
    public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AlunoMapeamento());
    }

    public DbSet<Aluno> Aluno { get; set; }
}