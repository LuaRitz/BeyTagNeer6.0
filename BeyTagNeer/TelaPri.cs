using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Control;
using Modelo;
using MySql.Data.MySqlClient;

namespace BeyTagNeer
{
    public partial class TelaPri : Form
    {
        Thread T1;
        Thread T2;
        Thread T3;
        Thread T4;
        Thread T5;
        UsuModelo usM = new UsuModelo();
        usucontroller usC = new usucontroller();
        CarrinhoModelo caMod = new CarrinhoModelo();
        public TelaPri(UsuModelo us)
        {
            usM = us;
            InitializeComponent();
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = usM.Usuario.ToString();
            if (usM.perfil == 2)
            {
               cadastrpd.Visible = true;
            }
            if (usM.perfil > 0)
            {
                Login.Visible = false;
            }
            DataTable produto = new DataTable();
            conexao conn = new conexao();
            ProModelo usP = new ProModelo();

            produto = conn.ObterDados("SELECT * FROM produtos");

            int x = 0, y = 0;
            for (int i = 0; i < produto.Rows.Count; i++)
            {
                Panel layout= new Panel();
                layout.Size = new Size(210,290);
                usP.codProduto = i;
                usP.codProduto++;
                DataRow row = produto.Rows[i];
                //MessageBox.Show(row["nomeproduto"].ToString());
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
                foto.SizeMode = PictureBoxSizeMode.StretchImage;
                foto.Size = new Size(210, 190);
                foto.Location = new Point(0, 0);
                foto.ImageLocation = row["imagem"].ToString();
                Button comprar = new Button();
                comprar.Location = new Point(5, 255);
                comprar.Size = new Size(200, 25);
                comprar.Text = "Comprar";
                comprar.Click += new EventHandler((sender1, e1) => RegistrarClick(sender1, e1, usP.codProduto.ToString()));

                layout.Location=new Point(x, y);
                layout.Controls.Add(nomeprod);
                layout.Controls.Add(preco);
                layout.Controls.Add(foto);
                layout.Controls.Add(comprar);
                x += 215;
                int o = i + 1;
                if (o % 4 == 0 && o != 0)
                {
                    y += 290;
                    x = 0;
                }
                panel1.Controls.Add(layout);
            }

        }
        private void RegistrarClick(object sender, EventArgs e, string id)
        {
            ball(id);
        }

        private void ball(string id)
        {
            this.Close();
            T3 = new Thread(abrirC);
            T3.SetApartmentState(ApartmentState.STA);
            T3.Start();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Close();
            T1 = new Thread(abrirCD);
            T1.SetApartmentState(ApartmentState.STA);
            T1.Start();
        }
        private void abrirCD(object obj)
        {
            Application.Run(new Cadastro());
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Close();
            T2 = new Thread(abrirTP);
            T2.SetApartmentState(ApartmentState.STA);
            T2.Start();
        }
        private void abrirTP(object obj)
        {
            Application.Run(new TelaPri(usM));
        }

        private void carrinho_Click(object sender, EventArgs e)
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

        private void cadastropd_Click(object sender, EventArgs e)
        {
            this.Close();
            T4 = new Thread(abrirCP);
            T4.SetApartmentState(ApartmentState.STA);
            T4.Start();
        }
        private void abrirCP(object obj)
        {
            Application.Run(new CadastroPD(usM));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void abrirf1(object obj)
        {
            Application.Run(new Form1());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            T5 = new Thread(abrirf1);
            T5.SetApartmentState(ApartmentState.STA);
            T5.Start();
        }
    }
}
