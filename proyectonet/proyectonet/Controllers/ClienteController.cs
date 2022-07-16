using Microsoft.AspNetCore.Mvc;

namespace proyectonet.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
