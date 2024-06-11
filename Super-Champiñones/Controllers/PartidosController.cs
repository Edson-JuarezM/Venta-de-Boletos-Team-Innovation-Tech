using Microsoft.AspNetCore.Mvc;

namespace Super_Champiñones.Controllers
{
    public class PartidosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
