using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class DadosController : AbstractController
    {
        public IActionResult Dados()
        {
            ViewData["NomeView"] = "user";
            return View();
        }
    }
}