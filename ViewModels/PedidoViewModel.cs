using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class PedidoViewModel : BaseViewModel
    {
        
        
        public string NomeUsuario {get;set;}
        public Cliente Cliente {get;set;}
        public List<Pedido> Pedidos {get;set;}

        public PedidoViewModel()
        {
            
            this.NomeUsuario = "User";
            this.Cliente = new Cliente();
            this.Pedidos = new List<Pedido>();
        }

        
    }
}