using Academia_De_Idiomas.Context;
using Academia_De_Idiomas.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academia_De_Idiomas.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly AplicacionDbContext _context;
        public UsuarioController(AplicacionDbContext context)
        {
            _context = context;
        }

        public IActionResult Registro()
        {
            var idiomas = _context.Idiomas.ToList();
            ViewBag.idiomas = idiomas;

            //var modalidad = _context.Modalidad.ToList();
            //ViewBag.modalidad = modalidad;

            return View();
        }

        //[HttpPost]
        //public IActionResult Registro(string NomAlum, string ApeAlum, string Correo, int Telefono, string Contraseña/*, string idioma, string modalidad*/)
        //{
        //    ViewBag.nombre = NomAlum;
        //    ViewBag.apellido = ApeAlum;
        //    ViewBag.gmail = Correo;
        //    ViewBag.telefono = Telefono;
        //    ViewBag.contraseña = Contraseña;
        //    //ViewBag.idioma = idioma;
        //    //ViewBag.modalidad = modalidad;

        //    return View();
        //}

        [HttpPost]
        //public IActionResult Registro(Alumnos alumnos)
        //{
        //    ViewBag.nombre = alumnos.NomAlum;
        //    ViewBag.apellido = alumnos.ApeAlum;
        //    ViewBag.gmail = alumnos.Correo;
        //    ViewBag.telefono = alumnos.Telefono;
        //    ViewBag.contraseña = alumnos.Contraseña;

        //    //_context.Alumnos.Add(alumnos);
        //    //_context.SaveChanges();
        //    ViewBag.idioma = alumnos.CodIdioma;
        //    //ViewBag.modalidad = modalidad;

        //    return View();
        //}

        public IActionResult Registro(string CodIdioma)
        {

            //_context.Alumnos.Add(alumnos);
            //_context.SaveChanges();
            ViewBag.idioma = CodIdioma;
            //ViewBag.modalidad = modalidad;

            return View();
        }
    }
}
