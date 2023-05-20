﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Control;
using Modelo;

namespace BeyTagNeer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable produto= new DataTable();
            conexao conn = new conexao();
            UsuModelo usM = new UsuModelo();
            usucontroller usC = new usucontroller();
            ProModelo usP = new ProModelo();

            produto = conn.ObterDados("SELECT * FROM produtos");
            

            for (int i = 0; i < produto.Rows.Count; i++)
            {
                usP.codProduto = i;
                usP.codProduto++;
                DataRow row = produto.Rows[i];
                MessageBox.Show(row["nomeproduto"].ToString());
                Label nomeprod = new Label();
                nomeprod.Name = "txtnome";
                nomeprod.Location = new Point(25, 195);
                nomeprod.Text = row["nomeproduto"].ToString();
                Label preco = new Label();
                preco.Name = "txtpreco";
                preco.Location = new Point(150, 210);
                preco.Text = row["preco"].ToString();
                PictureBox foto = new PictureBox();
                foto.Name = "txtfoto";
                foto.SizeMode= PictureBoxSizeMode.StretchImage;
                foto.Size = new Size(210, 190);
                foto.Location = new Point(0, 0);
                foto.ImageLocation = row["imagem"].ToString();

                panel1.Controls.Add(nomeprod);
                panel1.Controls.Add(preco);
                panel1.Controls.Add(foto);
            }

            
            
        }
    }
}
