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
            UsuModelo usM = new UsuModelo();
            usucontroller usC = new usucontroller();
            ProModelo usP = new ProModelo();

            for (int i = 1; i < 2; i++)
            {
                usP.codProduto = 1;
            }
            usP.codProduto++;

            Label nomeprod = new Label();
            nomeprod.Name = "txtnome";
            nomeprod.Location = new Point(185);


            panel1.Controls.Add(nomeprod);
            
        }
    }
}
