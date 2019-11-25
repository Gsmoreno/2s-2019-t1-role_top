using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Login()
        {
            ViewData["NomeView"] = "Home";
            return View();
        }

        public IActionResult Galeria()
        {
            ViewData["NomeView"] = "Fotos";
            return View();
        }

        public IActionResult Adm()
        {
            ViewData["NomeView"] = "adm";
            return View();
        }

        public IActionResult Usuario()
        {
            ViewData["NomeView"] = "user";
            return View();
        }

        public IActionResult Dados()
        {
            ViewData["NomeView"] = "user";
            return View();
        }
    }
}