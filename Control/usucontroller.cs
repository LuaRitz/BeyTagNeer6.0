﻿using Control;
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

        public int cadastrarP(ProModelo modelo)
        {
            int ValorCadastro = -1;
            try
            {
                string SQL = "INSERT INTO produtos(nomeproduto,imagem,Stock,preco)" + "values(@nomeproduto,@imagem,@Stock,@preco)";
                string[] campos = { "@nomeproduto", "@imagem", "@Stock", "@preco" };
                string[] valores = { modelo.NomePro, modelo.Imagem, Convert.ToString(modelo.Stock), Convert.ToString(modelo.Preco) };
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
                    string sql = "SELECT * FROM usuario where login=@login and senha=@senha"; 
                    MySqlConnection conn = con.getConexao();
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@login", us.Login);
                    cmd.Parameters.AddWithValue("@senha", us.Senha);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    us.codUsuario = Convert.ToInt32(reader["usercode"]);
                    us.perfil = Convert.ToInt32(reader["perfil"]);
                    us.Email = reader["email"].ToString();
                    us.NomeUsu = reader["nome"].ToString();
                    us.Imagem = reader["userimage"].ToString();
                reader.Close();
                    conn.Close();
                    return us;
                } catch (Exception ex)
                {
                    throw new Exception(ex.Message);        
                }
        }
        public bool excluir(UsuModelo usM)
        {
            bool result = false;
            string sql = "DELETE FROM usuario where usercode=" + usM.codUsuario;
            //chamando minha conexao
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();//abrindo o banco
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            if (cmd.ExecuteNonQuery() >= 1)
                result = true;
            sqlCon.Close();
            return result;
        }

        public bool editar(UsuModelo usM)
        {
            bool result = false;
            string sql = "UPDATE usuario set nome=@nome, email=@email, login=@login, perfil=@perfil where usercode=" +usM.codUsuario+"";
            MySqlConnection sqlcon = con.getConexao();
            sqlcon.Open();
            MySqlCommand command = new MySqlCommand(sql, sqlcon);
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;
            command.Parameters.AddWithValue("nome", usM.NomeUsu);
            command.Parameters.AddWithValue("email", usM.Email);
            command.Parameters.AddWithValue("login", usM.Login);
            command.Parameters.AddWithValue("perfil", usM.perfil);
            if (usM.Imagem != "") { 
            command.Parameters.AddWithValue("imagem", usM.Imagem);
            }
            if (command.ExecuteNonQuery() >= 1)
                result = true;
            sqlcon.Close();
            return result;
        }

        public CarrinhoModelo comprarPD(CarrinhoModelo caMod)
        {
            try { 
            string sql = "INSERT INTO carrinhocompras(data,uscode,cep) values (@data,@uscode,@cep)";
            MySqlConnection conn = con.getConexao();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@data", caMod.dataT);
                cmd.Parameters.AddWithValue("@uscode", caMod.usucode);
                cmd.Parameters.AddWithValue("@cep", caMod.CepL);
                cmd.ExecuteNonQuery();
                caMod.carrinhoCom = cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return caMod;
        }
    }
}
