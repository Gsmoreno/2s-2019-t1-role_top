using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Repositorios;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class DadosController : AbstractController
    {
        PedidoRepository pedidoRepository = new PedidoRepository();
        public IActionResult Dados()
        {
            var emailCliente = ObterUsuarioSession();
            var pedidosCliente = pedidoRepository.ObterTodosPorCliente(emailCliente);

            return View(new HistoricoViewModel()
            {
                Pedidos = pedidosCliente,
                NomeView = "Histórico",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}