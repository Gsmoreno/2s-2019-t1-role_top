using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class PedidoViewModel : BaseViewModel
    {
       
        
        public string NomeUsuario {get;set;}
        public Cliente Cliente {get;set;}

        public PedidoViewModel()
        {
            
            this.NomeUsuario = "Jovem";
            this.Cliente = new Cliente();
        }
    }
}