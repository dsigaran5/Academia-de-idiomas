using Microsoft.AspNetCore.Mvc;

namespace Academia_De_Idiomas.Controllers
{
    public class IdiomasController : Controller
    {
        public IActionResult Idiomas(string idioma)
        {
            ViewBag.idioma = idioma;
            return View();
        }
    }
}
