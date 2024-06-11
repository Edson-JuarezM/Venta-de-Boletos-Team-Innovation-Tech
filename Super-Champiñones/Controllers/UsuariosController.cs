using Microsoft.AspNetCore.Mvc;

namespace Super_Champiñones.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
