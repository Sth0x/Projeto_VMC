using Microsoft.AspNetCore.Mvc;

namespace Projeto_VMC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
