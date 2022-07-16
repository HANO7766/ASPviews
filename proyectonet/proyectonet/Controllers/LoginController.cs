using Microsoft.AspNetCore.Mvc;

namespace proyectonet.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
