using Microsoft.AspNetCore.Mvc;

namespace WebAppTarde.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
