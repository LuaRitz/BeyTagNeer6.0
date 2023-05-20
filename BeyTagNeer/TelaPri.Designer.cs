namespace BeyTagNeer
{
    partial class TelaPri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPri));
            this.Login = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.carrinho = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.cadastrpd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Black;
            this.Login.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(809, 32);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(199, 64);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login/Cadastro";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(1014, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(114, 98);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // carrinho
            // 
            this.carrinho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carrinho.BackgroundImage")));
            this.carrinho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carrinho.Location = new System.Drawing.Point(1150, 12);
            this.carrinho.Name = "carrinho";
            this.carrinho.Size = new System.Drawing.Size(110, 98);
            this.carrinho.TabIndex = 6;
            this.carrinho.UseVisualStyleBackColor = true;
            this.carrinho.Click += new System.EventHandler(this.carrinho_Click);
            // 
            // Home
            // 
            this.Home.BackgroundImage = global::BeyTagNeer.Properties.Resources.homeicon;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home.Location = new System.Drawing.Point(24, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(104, 98);
            this.Home.TabIndex = 23;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // cadastrpd
            // 
            this.cadastrpd.BackColor = System.Drawing.Color.Black;
            this.cadastrpd.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrpd.ForeColor = System.Drawing.Color.White;
            this.cadastrpd.Location = new System.Drawing.Point(165, 32);
            this.cadastrpd.Name = "cadastrpd";
            this.cadastrpd.Size = new System.Drawing.Size(225, 64);
            this.cadastrpd.TabIndex = 24;
            this.cadastrpd.Text = "Cadastra/Produto";
            this.cadastrpd.UseVisualStyleBackColor = false;
            this.cadastrpd.Visible = false;
            this.cadastrpd.Click += new System.EventHandler(this.cadastropd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1065, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(960, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaPri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BeyTagNeer.Properties.Resources.TelaPri;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1283, 688);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cadastrpd);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.carrinho);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.Login);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "TelaPri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telapri";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button carrinho;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button cadastrpd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}