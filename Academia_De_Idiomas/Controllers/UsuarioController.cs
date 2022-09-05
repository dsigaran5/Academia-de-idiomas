using Microsoft.AspNetCore.Mvc;

namespace Academia_De_Idiomas.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Registro()
        {
            return View();
        }
    }
}
