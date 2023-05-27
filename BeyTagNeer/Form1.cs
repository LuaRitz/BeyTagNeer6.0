using System;
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
using System.Threading;

namespace BeyTagNeer
{
    public partial class Form1 : Form
    {
        Thread T3;
        UsuModelo usM = new UsuModelo();
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
                Button comprar = new Button();
                comprar.Location = new Point(5, 255);
                comprar.Size = new Size(200, 25);
                comprar.Text = "Comprar";
                comprar.Click += new EventHandler((sender1, e1) => RegistrarClick(sender1, e1, usP.codProduto.ToString()));
                panel1.Controls.Add(nomeprod);
                panel1.Controls.Add(preco);
                panel1.Controls.Add(foto);
                panel1.Controls.Add(comprar);
            }

            
            
        }
        private void RegistrarClick(object sender, EventArgs e, string id)
        {
            ball();
        }

        private void ball()
        {
            this.Close();
            T3 = new Thread(abrirC);
            T3.SetApartmentState(ApartmentState.STA);
            T3.Start();
        }
    private void abrirC(object obj)
    {
        Application.Run(new Carrinho(usM));
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
