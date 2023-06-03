namespace BeyTagNeer
{
    partial class Perfs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfs));
            this.Home = new System.Windows.Forms.Button();
            this.carrinho = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.BackgroundImage = global::BeyTagNeer.Properties.Resources.homeicon;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home.Location = new System.Drawing.Point(24, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(104, 98);
            this.Home.TabIndex = 28;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // carrinho
            // 
            this.carrinho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carrinho.BackgroundImage")));
            this.carrinho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carrinho.Location = new System.Drawing.Point(1150, 12);
            this.carrinho.Name = "carrinho";
            this.carrinho.Size = new System.Drawing.Size(110, 98);
            this.carrinho.TabIndex = 27;
            this.carrinho.UseVisualStyleBackColor = true;
            this.carrinho.Click += new System.EventHandler(this.carrinho_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(1014, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(114, 98);
            this.pictureBox.TabIndex = 26;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(258, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 184);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(462, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 287);
            this.panel1.TabIndex = 30;
            // 
            // Perfs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BeyTagNeer.Properties.Resources.TelaPri;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1283, 688);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.carrinho);
            this.Controls.Add(this.pictureBox);
            this.Name = "Perfs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfs";
            this.Load += new System.EventHandler(this.Perfs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button carrinho;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}