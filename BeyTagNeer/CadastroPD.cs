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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BeyTagNeer
{
    public partial class CadastroPD : Form

    {
        Thread T2;
        ProModelo pMod = new ProModelo();
        UsuModelo usM = new UsuModelo();
        usucontroller usC = new usucontroller();
        public CadastroPD(UsuModelo us)
        {
            usM = us;
            InitializeComponent();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void registrar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            if (stock.Text == "")
            {
                MessageBox.Show("Preencha a quantidade de Estoque!");
            }
            else if (nomepro.Text == "")
            {
                MessageBox.Show("De o nome do produto!");
            }
            else if (preco.Text == "")
            {
                MessageBox.Show("insira o preço!");
            }
            else if (imPro.Text == "")
            {
                MessageBox.Show("Coloque a Imagem!");
            }
            else
            {
                pMod.Stock = Convert.ToInt32(stock.Text);
                pMod.NomePro = nomepro.Text;
                pMod.Preco = Convert.ToDouble(preco.Text);
                pMod.Imagem = fotoptxt.Text;
                if (usC.cadastrarP(pMod) == 1)
                {
                    MessageBox.Show("sucesso");
                }
                else
                {
                    MessageBox.Show("Falha");
                }
            }


        }

        private void nomecad_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog oppro = new OpenFileDialog();
                oppro.Filter = "image file (*.jpg;*.png) | *.png; *.jpg;";
                if (oppro.ShowDialog() == DialogResult.OK)
                {
                    fotoptxt.Text = oppro.FileName;
                    imPro.Image = Image.FromFile(oppro.FileName);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha" + ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void senhacad2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void senhacad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void usucad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void fototxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
