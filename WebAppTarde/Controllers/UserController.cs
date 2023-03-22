using Microsoft.AspNetCore.Mvc;

namespace WebAppTarde.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
