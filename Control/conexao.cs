using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Control
{
    public class conexao
    {
        static private string servidor = "localhost";//caminho do servidor
        static private string bancodedados = "cadastro";//nome do banco
        static private string usuario = "root";//nome padrao
        static private string senha = "";
        static public string StrCon = "server=" + servidor + ";database=" +
        bancodedados + ";user id=" + usuario + ";password=" + senha;
        public MySqlConnection conn = null;
        public MySqlConnection getConexao()
        {
            conn = new MySqlConnection(StrCon);
            return conn;
        }
        public int cadastrar(string[]campos, string[] valores, string SQLInsert)
        {
            int registro = -1;
            try
            {
               conn = getConexao();
                conn.Open();
                MySqlCommand cnd = new MySqlCommand(SQLInsert, conn);
                cnd.CommandType = CommandType.Text;
                cnd.CommandText = SQLInsert;

                for (int i = 0; i < valores.Length; i++) 
                {
                    cnd.Parameters.AddWithValue(campos [i], valores[i]);
                }
                registro = cnd.ExecuteNonQuery();
                conn.Close();
                return registro;
                
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        
    }
}
