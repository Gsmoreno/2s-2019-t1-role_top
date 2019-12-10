using System;
using RoleTopMVC.Enums;

namespace RoleTopMVC.Models
{
    public class Pedido
    {
        public ulong Id {get;set;}
        public Cliente Cliente {get;set;}
        
        

        public DateTime DataDoPedido {get;set;}
        public string Pagamento {get;set;}
        

        public uint Status {get;set;}

        public Pedido()
        {
            this.Cliente = new Cliente();
            this.DataDoPedido = DataDoPedido;
            this.Id = 0;
            this.Status = (uint) StatusPedido.PENDENTE;
            this.Pagamento = "Pendente";
        }
    }
}