﻿namespace BeyTagNeer
{
    partial class CadastroPD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Home = new System.Windows.Forms.Button();
            this.fotoptxt = new System.Windows.Forms.TextBox();
            this.registrar = new System.Windows.Forms.Button();
            this.nomepro = new System.Windows.Forms.TextBox();
            this.imPro = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.codp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imPro)).BeginInit();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.BackgroundImage = global::BeyTagNeer.Properties.Resources.homeicon;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home.Location = new System.Drawing.Point(24, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(104, 98);
            this.Home.TabIndex = 24;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // fotoptxt
            // 
            this.fotoptxt.Location = new System.Drawing.Point(373, 381);
            this.fotoptxt.Name = "fotoptxt";
            this.fotoptxt.Size = new System.Drawing.Size(142, 20);
            this.fotoptxt.TabIndex = 38;
            this.fotoptxt.TextChanged += new System.EventHandler(this.fototxt_TextChanged);
            // 
            // registrar
            // 
            this.registrar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrar.Location = new System.Drawing.Point(579, 366);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(224, 35);
            this.registrar.TabIndex = 37;
            this.registrar.Text = "Cadastrar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // nomepro
            // 
            this.nomepro.Location = new System.Drawing.Point(545, 299);
            this.nomepro.Name = "nomepro";
            this.nomepro.Size = new System.Drawing.Size(364, 20);
            this.nomepro.TabIndex = 36;
            this.nomepro.TextChanged += new System.EventHandler(this.nomecad_TextChanged);
            // 
            // imPro
            // 
            this.imPro.Location = new System.Drawing.Point(373, 239);
            this.imPro.Name = "imPro";
            this.imPro.Size = new System.Drawing.Size(142, 132);
            this.imPro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imPro.TabIndex = 35;
            this.imPro.TabStop = false;
            this.imPro.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(542, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Nome do Produto";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // codp
            // 
            this.codp.Location = new System.Drawing.Point(545, 260);
            this.codp.Name = "codp";
            this.codp.Size = new System.Drawing.Size(364, 20);
            this.codp.TabIndex = 27;
            this.codp.TextChanged += new System.EventHandler(this.usucad_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Produto";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(614, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cadastro Produto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CadastroPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BeyTagNeer.Properties.Resources.TelaPri;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1283, 688);
            this.Controls.Add(this.fotoptxt);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.nomepro);
            this.Controls.Add(this.imPro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.codp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Home);
            this.Name = "CadastroPD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroPD";
            ((System.ComponentModel.ISupportInitialize)(this.imPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.TextBox fotoptxt;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.TextBox nomepro;
        private System.Windows.Forms.PictureBox imPro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox codp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}