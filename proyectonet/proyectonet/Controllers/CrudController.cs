using Microsoft.AspNetCore.Mvc;

namespace proyectonet.Controllers
{
    public class CrudController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
