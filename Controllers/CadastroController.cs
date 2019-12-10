using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Models;
using RoleTopMVC.Repositorios;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class CadastroController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();

        public IActionResult Index()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult CadastrarCliente(IFormCollection form)
        {
            ViewData["Action"] = "Cadastro";
            try
            {
                Cliente cliente = new Cliente(
                    form["nome"],
                    form["email"],
                    form["telefone"],
                    form["senha"]);
                    
                    
                    

                cliente.TipoUsuario = (uint) TiposUsuario.CLIENTE;
                

                if (!string.IsNullOrEmpty(form["nome"]) && !string.IsNullOrEmpty(form["email"]) && !string.IsNullOrEmpty(form["senha"]) && !string.IsNullOrEmpty(form["telefone"]))
                {
                clienteRepository.Inserir(cliente);

                return View("Sucesso", new RespostaViewModel()
                {
                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                    
                });
                    
                }else
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine();
                    System.Console.WriteLine();
                    return View("Erro", new RespostaViewModel());
                }
                
                
            } 
            catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    }
}