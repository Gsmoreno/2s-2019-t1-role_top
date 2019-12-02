
using System;

namespace RoleTopMVC.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        
        public uint TipoUsuario {get;set;}

        public Cliente()
        {

        }

        public Cliente(string nome,  string telefone, string senha, string email)
        {
            this.Nome = nome;
            
            this.Telefone = telefone;
            this.Senha =  senha;
            this.Email = email;
            
            
        }
    }
}
    
