using Microsoft.AspNetCore.Mvc;

namespace Libros.Controllers
{
    public class HomeController : Controller
    {
        // Página principal
        public IActionResult Index()
        {
            return View();
        }

        // Página de información del sitio
        public IActionResult Informacion()
        {
            return View();
        }

        // Página de opiniones de libros
        public IActionResult Opiniones()
        {
            return View();
        }

        // Página de contacto
        public IActionResult Contacto()
        {
            return View();
        }
    }
}