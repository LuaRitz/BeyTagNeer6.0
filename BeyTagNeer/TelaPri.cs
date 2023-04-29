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

namespace BeyTagNeer
{
    public partial class TelaPri : Form
    {
        Thread T1;
        Thread T2;
        Thread T3;
        Thread T4;
        UsuModelo usM = new UsuModelo();
        usucontroller usC = new usucontroller();
        public TelaPri(UsuModelo us)
        {
            usM = us;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = usM.codUsuario.ToString();
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
            Application.Run(new Carrinho());
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
            Application.Run(new CadastroPD());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
