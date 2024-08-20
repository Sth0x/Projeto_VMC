using Microsoft.AspNetCore.Mvc;

namespace Projeto_VMC.Controllers
{
    public class ProfessoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
