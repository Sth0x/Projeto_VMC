using Projeto_VMC.Data.Repositorio.Interfaces;
using Projeto_VMC.Models;

public class AlunoRepositorio : IAlunoRepositorio
{

    private readonly BancoContexto _bancoContexto;

    public AlunoRepositorio(BancoContexto bancoContexto)
    {
        _bancoContexto = bancoContexto;
    }

    public List<Aluno> BuscarAlunos()
    {
        return _bancoContexto.Aluno.ToList();
    }
}