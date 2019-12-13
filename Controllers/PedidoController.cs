using System;
using System.Net.Mail;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Models;
using RoleTopMVC.Repositorios;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class PedidoController : AbstractController
    {
        PedidoRepository pedidoRepository = new PedidoRepository();


        ClienteRepository clienteRepository = new ClienteRepository();



        public IActionResult Pedido()
        {

            PedidoViewModel pvm = new PedidoViewModel();


            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();
            if (!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                pvm.NomeUsuario = nomeUsuarioLogado;
            }

            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
            if (clienteLogado != null)
            {
                pvm.Cliente = clienteLogado;
            }

            pvm.NomeView = "Pedido";
            pvm.UsuarioEmail = usuarioLogado;
            pvm.UsuarioNome = nomeUsuarioLogado;

            return View(pvm);
        }

        public IActionResult Registrar(IFormCollection form)
        {

            try
            {
                ViewData["Action"] = "Pedido";
                Pedido pedido = new Pedido();



                Cliente cliente = new Cliente()
                {
                    Nome = form["nome"],
                    Telefone = form["telefone"],
                    Email = form["email"]
                };

                pedido.Cliente = cliente;

                pedido.DataDoPedido = DateTime.Parse(form["data"]);



                if (pedidoRepository.Inserir(pedido))
                {
                    return View("Sucesso", new RespostaViewModel()
                    {
                        NomeView = "Pedido",
                        UsuarioEmail = ObterUsuarioSession(),
                        UsuarioNome = ObterUsuarioNomeSession()

                    });
                }
                else
                {
                    return View("Erro", new RespostaViewModel()
                    {
                        NomeView = "Pedido",
                        UsuarioEmail = ObterUsuarioSession(),
                        UsuarioNome = ObterUsuarioNomeSession(),

                    });
                }

            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel("Insira os dados para agendar o evento!"));
            }



        }

        public IActionResult Aprovar(ulong id)
        {
            var pedido = pedidoRepository.ObterPor(id);
            pedido.Status = (uint)StatusPedido.APROVADO;

            if (pedidoRepository.Atualizar(pedido))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível aprovar este pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }

        public IActionResult Reprovar(ulong id)
        {
            var pedido = pedidoRepository.ObterPor(id);
            pedido.Status = (uint)StatusPedido.REPROVADO;

            if (pedidoRepository.Atualizar(pedido))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível reprovar este pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }

        string menssagem = "Parabéns o seu pedido foi cadastrado iremos entrar em contato em breve para podermos acertar o APROVAMENTO do evento";
        protected IActionResult EnviarEmail(object sender, EventArgs e)
        {
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("roletopsenai132@gmail.com", "roletop123");
            MailMessage mail = new MailMessage();
            mail.Sender = new System.Net.Mail.MailAddress("Parabéns o seu pedido foi cadastrado iremos entrar em contato em breve para podermos acertar o APROVAMENTO do evento", "RoleTop!");
            mail.From = new MailAddress("RoleTop!", "Aqui seu role fica top!");
            mail.To.Add(new MailAddress("Cliente", "Evento"));
            mail.Subject = "Contato";
            mail.Body = " Mensagem do site:<br/> Nome:  " + SESSION_CLIENTE_NOME + "<br/> Email : " + SESSION_CLIENTE_EMAIL + " <br/> Mensagem : " + menssagem;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            try
            {
                client.Send(mail);
            }
            catch (System.Exception er)
            {
                System.Console.WriteLine(er.StackTrace);
                

            }
            finally
            {
                mail = null;
            }
            return RedirectToAction("Registrar", "Pedido");
        }
    }
}