
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

        public Cliente(string nome,string email,  string telefone, string senha )
        {
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
            this.Senha =  senha;
            
            
            
            
            
        }
    }
}
    
