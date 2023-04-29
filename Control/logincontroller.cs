using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Control
{

    public class logincontroller
    {
        conexao con = new conexao();

        public UsuModelo logincontrol(UsuModelo us)
        {
            try
            {
                ConsultarDados cons = new ConsultarDados();
                MySqlDataReader dt = cons.select("select * from tb_usuario where login = '" + us.Login + "' and senha = '" + us.Senha + "'");
                while (dt.Read())
                {
                    us.codUsuario = Convert.ToInt32(dt["usercode"]);
                    us.NomeUsu = dt["login"].ToString();
                    us.perfil = Convert.ToInt32(dt["perfil"]);

                }
            }
            catch 
            {

            }
            return us;

        }
    }
}
