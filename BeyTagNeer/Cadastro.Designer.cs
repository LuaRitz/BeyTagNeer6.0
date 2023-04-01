namespace BeyTagNeer
{
    partial class Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lologin = new System.Windows.Forms.TextBox();
            this.senhalogin = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usucad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.senhacad = new System.Windows.Forms.TextBox();
            this.senhacad2 = new System.Windows.Forms.MaskedTextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nomecad = new System.Windows.Forms.TextBox();
            this.registrar = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.fototxt = new System.Windows.Forms.TextBox();
            this.Home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lologin
            // 
            this.lologin.Location = new System.Drawing.Point(468, 531);
            this.lologin.Name = "lologin";
            this.lologin.Size = new System.Drawing.Size(353, 20);
            this.lologin.TabIndex = 0;
            this.lologin.TextChanged += new System.EventHandler(this.lologin_TextChanged);
            // 
            // senhalogin
            // 
            this.senhalogin.Location = new System.Drawing.Point(463, 583);
            this.senhalogin.Name = "senhalogin";
            this.senhalogin.Size = new System.Drawing.Size(353, 20);
            this.senhalogin.TabIndex = 1;
            this.senhalogin.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(631, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(604, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cadastro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 567);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Usuário";
            // 
            // usucad
            // 
            this.usucad.Location = new System.Drawing.Point(463, 228);
            this.usucad.Name = "usucad";
            this.usucad.Size = new System.Drawing.Size(364, 20);
            this.usucad.TabIndex = 7;
            this.usucad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Senha";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(655, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Repetir senha";
            // 
            // senhacad
            // 
            this.senhacad.Location = new System.Drawing.Point(463, 267);
            this.senhacad.Name = "senhacad";
            this.senhacad.Size = new System.Drawing.Size(176, 20);
            this.senhacad.TabIndex = 10;
            // 
            // senhacad2
            // 
            this.senhacad2.Location = new System.Drawing.Point(658, 267);
            this.senhacad2.Name = "senhacad2";
            this.senhacad2.Size = new System.Drawing.Size(169, 20);
            this.senhacad2.TabIndex = 11;
            this.senhacad2.UseSystemPasswordChar = true;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(463, 319);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(364, 20);
            this.email.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(291, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nomecad
            // 
            this.nomecad.Location = new System.Drawing.Point(463, 365);
            this.nomecad.Name = "nomecad";
            this.nomecad.Size = new System.Drawing.Size(364, 20);
            this.nomecad.TabIndex = 16;
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(536, 423);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(224, 35);
            this.registrar.TabIndex = 17;
            this.registrar.Text = "Cadastrar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(569, 625);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(159, 51);
            this.login.TabIndex = 18;
            this.login.Text = "Logar";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // fototxt
            // 
            this.fototxt.Location = new System.Drawing.Point(291, 349);
            this.fototxt.Name = "fototxt";
            this.fototxt.Size = new System.Drawing.Size(142, 20);
            this.fototxt.TabIndex = 19;
            // 
            // Home
            // 
            this.Home.BackgroundImage = global::BeyTagNeer.Properties.Resources.homeicon;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home.Location = new System.Drawing.Point(24, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(104, 98);
            this.Home.TabIndex = 22;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BeyTagNeer.Properties.Resources.TelaPri;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1283, 688);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.fototxt);
            this.Controls.Add(this.login);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.nomecad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.email);
            this.Controls.Add(this.senhacad2);
            this.Controls.Add(this.senhacad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.usucad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.senhalogin);
            this.Controls.Add(this.lologin);
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lologin;
        private System.Windows.Forms.MaskedTextBox senhalogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usucad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox senhacad;
        private System.Windows.Forms.MaskedTextBox senhacad2;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nomecad;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox fototxt;
        private System.Windows.Forms.Button Home;
    }
}

