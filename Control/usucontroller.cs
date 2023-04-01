using Control;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class usucontroller : UsuModelo
    {
       
        conexao con=new conexao();
        public usucontroller()
        {

        }
        public int cadastrar(UsuModelo modelo)
        {
            int ValorCadastro = -1;
            try
            {
                string SQL = "INSERT INTO usuario(nome,email,login,senha,userimage)" + "values(@nome,@email,@login,@senha,@userimage)";
                string[] campos = {"@nome", "@email", "@login", "@senha", "@userimage"} ;
                string[] valores = { modelo.NomeUsu, modelo.Email, modelo.Login, modelo.Senha, modelo.Imagem };

                if (con.cadastrar(campos, valores, SQL) >= 1)
                {
                    ValorCadastro = 1;
                }
                else
                {
                    ValorCadastro = 0;
                }
                }catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            return ValorCadastro;
          
        }
    }
}
