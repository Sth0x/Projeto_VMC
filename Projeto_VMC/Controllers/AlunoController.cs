using Microsoft.AspNetCore.Mvc;


namespace Projeto_VMC.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoRepositorio _AlunoRepositorio;
        public AlunoController(AlunoRepositorio alunoRepositorio)
        {
            _AlunoRepositorio = alunoRepositorio;   
        }
        public IActionResult Index()
        {
            var aluno = _AlunoRepositorio.BuscarAlunos();
            return View(aluno);
        }
    }
}
