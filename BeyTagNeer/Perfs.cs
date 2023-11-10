using Control;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            conexao conn = new conexao();
            nometxt.Text = usM.NomeUsu;
            emailtxt.Text = usM.Email;
            login.Text = usM.Login;
            pictureBox1.Text = usM.Imagem;
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
    }
}
