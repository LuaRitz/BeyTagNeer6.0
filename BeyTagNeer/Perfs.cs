using Control;
using Modelo;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BeyTagNeer
{
    public partial class Perfs : Form
    {
        Thread T2;
        Thread T3;
        Thread T6;
        UsuModelo usM = new UsuModelo();
        usucontroller usC = new usucontroller();
        CarrinhoModelo caMod = new CarrinhoModelo();
        public Perfs(UsuModelo us)
        {
            usM = us;
            InitializeComponent();
        }

        private void Perfs_Load(object sender, EventArgs e)
        {
            if (usM.perfil == 2)
            {
                perf.Visible = true;
                label7.Visible = true;
            }
            if (usM.codUsuario != 0)
            {
                if (usM.Imagem != "")
                {
                    pictureBox1.Load(usM.Imagem);
                }
            }
            conexao conn = new conexao();
            nometxt.Text = usM.NomeUsu;
            emailtxt.Text = usM.Email;
            login.Text = usM.Login;
            perf.Text = Convert.ToString(usM.perfil);
            
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
            T6 = new Thread(abrirPerf);
            T6.SetApartmentState(ApartmentState.STA);
            T6.Start();
        }
        private void abrirPerf(object obj)
        {
            Application.Run(new Perfs(usM));
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

        private void dele_Click(object sender, EventArgs e)
        {
            usC.excluir(usM);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (senat.Text == usM.Senha) { 
            usM.NomeUsu = nometxt.Text;
            usM.Email = emailtxt.Text;
            usM.Login = login.Text;
            usM.perfil = Convert.ToInt32(perf.Text);
            usM.Imagem = pictureBox1.Text;
            usC.editar(usM);
            MessageBox.Show("sucesso");
            }
            else
            {
                MessageBox.Show("INFORME A SENHA PARA ALTERAR OS DADOS!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "image file (*.jpg;*.png) | *.png; *.jpg;";
                string caminhofoto = @"/Fotos";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Text = open.FileName;
                    pictureBox1.Image = Image.FromFile(open.FileName);
                }
                File.Copy(open.FileName, caminhofoto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha" + ex.Message);
            }
        }
    }
}
