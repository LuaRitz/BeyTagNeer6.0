using Control;
using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class usucontroller : UsuModelo
    {

        conexao con = new conexao();
        public usucontroller()
        {
        }

        public int cadastrar(UsuModelo modelo)
        {
            int ValorCadastro = -1;
            try
            {
                string SQL = "INSERT INTO usuario(nome,email,login,senha,userimage)" + "values(@nome,@email,@login,@senha,@userimage)";
                string[] campos = { "@nome", "@email", "@login", "@senha", "@userimage" };
                string[] valores = { modelo.NomeUsu, modelo.Email, modelo.Login, modelo.Senha, modelo.Imagem };

                if (con.cadastrar(campos, valores, SQL) >= 1)
                {
                    ValorCadastro = 1;
                }
                else
                {
                    ValorCadastro = 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ValorCadastro;

        }

        public UsuModelo logar(UsuModelo us)
            {
             
                try
                {
                    string sql = "SELECT usercode FROM usuario where login=@login and senha=@senha";
                    MySqlConnection conn = con.getConexao();
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@login", us.Login);
                    cmd.Parameters.AddWithValue("@senha", us.Senha);
                    us.codUsuario = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    return us;
                } catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
        }
    }
}
