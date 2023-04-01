using System;
using Control;
using Modelo;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BeyTagNeer
{
    public partial class Cadastro : Form
    {
        Thread T2;
        UsuModelo usM = new UsuModelo();
        usucontroller usC = new usucontroller();
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            if (nomecad.Text == "")
            {
                MessageBox.Show("Preencha seu nome!");
            }
            else if (email.Text == "")
            {
                MessageBox.Show("Preencha seu email!");
            }
            else if (usucad.Text == "")
            {
                MessageBox.Show("Preencha seu usuário!");
            }
            else if (senhacad.Text == "")
            {
                MessageBox.Show("Preencha sua senha!");
            } 
            else if (senhacad.Text == senhacad2.Text)
            {

            usM.NomeUsu = nomecad.Text;
            usM.Email = email.Text;
            usM.Login = usucad.Text;
            usM.Senha = senhacad.Text;
            usM.Imagem = fototxt.Text;
              if(usC.cadastrar(usM) == 1)
                {
                    MessageBox.Show("sucesso");
                }
                else
                {
                    MessageBox.Show("Falha");
                }
             }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "imagem file | *.png; *.jpg: *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    fototxt.Text = open.FileName;
                    pictureBox1.Image = Image.FromFile(open.FileName);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha" + ex.Message);
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
        }

        private void lologin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

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
            Application.Run(new TelaPri());
        }
    }
}
