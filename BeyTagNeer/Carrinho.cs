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
    public partial class Carrinho : Form
    {
        Thread T2;
        Thread T3;
        UsuModelo usM = new UsuModelo();
        usucontroller usC = new usucontroller();
        public Carrinho(UsuModelo us)
        {
            usM= us;
            InitializeComponent();
        }

        private void Carrinho_Load(object sender, EventArgs e)
        {
            MessageBox.Show(usM.codUsuario.ToString());        }

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

        private void button1_Click(object sender, EventArgs e)
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
