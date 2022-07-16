using Microsoft.AspNetCore.Mvc;

namespace proyectonet.Controllers
{
    public class CarritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
