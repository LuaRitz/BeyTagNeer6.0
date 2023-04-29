using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class UsuModelo
    {
        private int CodigoUsuario;
        private string NomeUsuario;
        private int codigoperfil;
        private string usuario;
        private string senha;
        private string email;
        private string imagem;
        private string login;
       

        public UsuModelo()
        {
            CodigoUsuario = 0;
            NomeUsuario = "";
            codigoperfil = 0;
            usuario = "";
            senha = "";
            
        }
        
        public int codUsuario{
            get { return CodigoUsuario; }
            set { CodigoUsuario = value;}
        }
        public string NomeUsu
        {
            get { return NomeUsuario; }
            set { NomeUsuario = value;}
        }
        public int perfil
        { 
            get { return codigoperfil; }
            set{ codigoperfil = value;} 
        }
        public string Usuario
        {
            get { return usuario; }
            set {usuario = value;}
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value;}
        }
        public string Imagem
        {
            get { return imagem; }
            set { imagem = value;}
        }
        public string Email {
            get { return email; }
            set { email = value;}
        }
        public string Login {
            get { return login; } 
            set { login = value;}
        }
    }
}
