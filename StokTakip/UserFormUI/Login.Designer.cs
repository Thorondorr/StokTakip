
namespace UserFormUI
{
    partial class Login
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
            this.txtBox_kullanıcıAdı = new System.Windows.Forms.TextBox();
            this.txtBox_Sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttn_Giris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_kullanıcıAdı
            // 
            this.txtBox_kullanıcıAdı.Location = new System.Drawing.Point(118, 298);
            this.txtBox_kullanıcıAdı.Name = "txtBox_kullanıcıAdı";
            this.txtBox_kullanıcıAdı.Size = new System.Drawing.Size(189, 22);
            this.txtBox_kullanıcıAdı.TabIndex = 0;
            // 
            // txtBox_Sifre
            // 
            this.txtBox_Sifre.Location = new System.Drawing.Point(118, 326);
            this.txtBox_Sifre.Name = "txtBox_Sifre";
            this.txtBox_Sifre.Size = new System.Drawing.Size(189, 22);
            this.txtBox_Sifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // bttn_Giris
            // 
            this.bttn_Giris.Location = new System.Drawing.Point(118, 365);
            this.bttn_Giris.Name = "bttn_Giris";
            this.bttn_Giris.Size = new System.Drawing.Size(189, 41);
            this.bttn_Giris.TabIndex = 5;
            this.bttn_Giris.Text = "Giriş";
            this.bttn_Giris.UseVisualStyleBackColor = true;
            this.bttn_Giris.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserFormUI.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(97, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 244);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.bttn_Giris);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_Sifre);
            this.Controls.Add(this.txtBox_kullanıcıAdı);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_kullanıcıAdı;
        private System.Windows.Forms.TextBox txtBox_Sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttn_Giris;
    }
}

