using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;

namespace Control
{
    public class carcon
    {
        UsuModelo usM = new UsuModelo();
        CarrinhoModelo ca = new CarrinhoModelo();
        conexao con = new conexao();
        public carcon()
        {

        }
        public int criaca(CarrinhoModelo model, UsuModelo uss)
        {
            int carrinho = 0;
            if (model.usucode != uss.codUsuario)
            {
                string SQL = "INSERT INTO carrinhocompras(data,usucode,cep)" + "values(@data,@uscode,@cep)";
                string[] campos = { "@data", "@uscode", "@cep" };
                string[] valores = { model.dataT.ToString(), uss.codUsuario.ToString(), model.CepL.ToString() };
                MySqlConnection conn = con.getConexao();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@data", model.dataT);
                cmd.Parameters.AddWithValue("@uscode", uss.codUsuario);
                cmd.Parameters.AddWithValue("@cep", model.CepL);
                cmd.ExecuteNonQuery();
                model.carrinhoCom = cmd.LastInsertedId;
                carrinho = (int)cmd.LastInsertedId;
            }
            else if (carrinho>=1)
            {
                string SQL = "UPDATE INTO carrinhocompras(data,usucode,cep)" + "values(@data,@uscode,@cep)";
                string[] campos = { "@data", "@uscode", "@cep" };
                string[] valores = { model.dataT.ToString(), uss.codUsuario.ToString(), model.CepL.ToString() };
                MySqlConnection conn = con.getConexao();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@data", model.dataT);
                cmd.Parameters.AddWithValue("@uscode", uss.codUsuario);
                cmd.Parameters.AddWithValue("@cep", model.CepL);
                cmd.ExecuteNonQuery();
                model.carrinhoCom = cmd.LastInsertedId;
                carrinho = (int)cmd.LastInsertedId; ;
            }
            return carrinho;
        }




    }
}

            
        
    

