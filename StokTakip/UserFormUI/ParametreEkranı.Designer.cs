
namespace UserFormUI
{
    partial class ParametreEkranı
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
            this.txtbox_serverAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_serverKullanıcıAdi = new System.Windows.Forms.TextBox();
            this.txtbox_serverSifresi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_sirketAdi = new System.Windows.Forms.TextBox();
            this.dataGridView_parametreEkranı = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_kullanıcıId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbox_sifre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbox_kullanıcıAdı = new System.Windows.Forms.TextBox();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parametreEkranı)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_serverAdi
            // 
            this.txtbox_serverAdi.Location = new System.Drawing.Point(145, 47);
            this.txtbox_serverAdi.Name = "txtbox_serverAdi";
            this.txtbox_serverAdi.Size = new System.Drawing.Size(143, 22);
            this.txtbox_serverAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Server Kullanıcı Adı";
            // 
            // txtbox_serverKullanıcıAdi
            // 
            this.txtbox_serverKullanıcıAdi.Location = new System.Drawing.Point(145, 75);
            this.txtbox_serverKullanıcıAdi.Name = "txtbox_serverKullanıcıAdi";
            this.txtbox_serverKullanıcıAdi.Size = new System.Drawing.Size(143, 22);
            this.txtbox_serverKullanıcıAdi.TabIndex = 4;
            // 
            // txtbox_serverSifresi
            // 
            this.txtbox_serverSifresi.Location = new System.Drawing.Point(145, 106);
            this.txtbox_serverSifresi.Name = "txtbox_serverSifresi";
            this.txtbox_serverSifresi.Size = new System.Drawing.Size(143, 22);
            this.txtbox_serverSifresi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Server Şifresi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şirket Adı";
            // 
            // txtbox_sirketAdi
            // 
            this.txtbox_sirketAdi.Location = new System.Drawing.Point(145, 19);
            this.txtbox_sirketAdi.Name = "txtbox_sirketAdi";
            this.txtbox_sirketAdi.Size = new System.Drawing.Size(143, 22);
            this.txtbox_sirketAdi.TabIndex = 6;
            this.txtbox_sirketAdi.Text = "Akana Mühendislik";
            // 
            // dataGridView_parametreEkranı
            // 
            this.dataGridView_parametreEkranı.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_parametreEkranı.Location = new System.Drawing.Point(12, 166);
            this.dataGridView_parametreEkranı.Name = "dataGridView_parametreEkranı";
            this.dataGridView_parametreEkranı.RowHeadersWidth = 51;
            this.dataGridView_parametreEkranı.RowTemplate.Height = 24;
            this.dataGridView_parametreEkranı.Size = new System.Drawing.Size(945, 150);
            this.dataGridView_parametreEkranı.TabIndex = 8;
            this.dataGridView_parametreEkranı.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_parametreEkranı_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kullanıcı Bilgileri";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(808, 24);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(149, 28);
            this.btn_ekle.TabIndex = 10;
            this.btn_ekle.Text = "Kullanıcı Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Kullanıcı Id";
            // 
            // txtbox_kullanıcıId
            // 
            this.txtbox_kullanıcıId.Location = new System.Drawing.Point(636, 16);
            this.txtbox_kullanıcıId.Name = "txtbox_kullanıcıId";
            this.txtbox_kullanıcıId.Size = new System.Drawing.Size(143, 22);
            this.txtbox_kullanıcıId.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "E mail";
            // 
            // txtbox_email
            // 
            this.txtbox_email.Location = new System.Drawing.Point(636, 103);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(143, 22);
            this.txtbox_email.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Şifre";
            // 
            // txtbox_sifre
            // 
            this.txtbox_sifre.Location = new System.Drawing.Point(636, 72);
            this.txtbox_sifre.Name = "txtbox_sifre";
            this.txtbox_sifre.Size = new System.Drawing.Size(143, 22);
            this.txtbox_sifre.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(503, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Kullanıcı Adı";
            // 
            // txtbox_kullanıcıAdı
            // 
            this.txtbox_kullanıcıAdı.Location = new System.Drawing.Point(636, 44);
            this.txtbox_kullanıcıAdı.Name = "txtbox_kullanıcıAdı";
            this.txtbox_kullanıcıAdı.Size = new System.Drawing.Size(143, 22);
            this.txtbox_kullanıcıAdı.TabIndex = 13;
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Location = new System.Drawing.Point(808, 58);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(149, 28);
            this.btn_güncelle.TabIndex = 10;
            this.btn_güncelle.Text = "Kullanıcı Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(808, 92);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(149, 28);
            this.btn_sil.TabIndex = 10;
            this.btn_sil.Text = "Kullanıcı Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // ParametreEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 343);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbox_kullanıcıId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbox_sifre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbox_kullanıcıAdı);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView_parametreEkranı);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_sirketAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_serverSifresi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_serverKullanıcıAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_serverAdi);
            this.Name = "ParametreEkranı";
            this.Text = "ParametreEkranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ParametreEkranı_FormClosed);
            this.Load += new System.EventHandler(this.ParametreEkranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_parametreEkranı)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_serverAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_serverKullanıcıAdi;
        private System.Windows.Forms.TextBox txtbox_serverSifresi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_sirketAdi;
        private System.Windows.Forms.DataGridView dataGridView_parametreEkranı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_kullanıcıId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbox_sifre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbox_kullanıcıAdı;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_sil;
    }
}