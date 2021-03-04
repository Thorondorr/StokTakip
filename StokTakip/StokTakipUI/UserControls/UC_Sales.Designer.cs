
namespace StokTakipUI.UserControls
{
    partial class UC_Sales
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_right = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_ürün = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_miktar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_toplamTutar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_satış = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txtbox_miktar = new System.Windows.Forms.TextBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_fiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_ürünkod = new System.Windows.Forms.TextBox();
            this.txtbox_ürünkdv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbox_ürünbarkod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbox_cariNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbox_cariAd = new System.Windows.Forms.ComboBox();
            this.cmbox_ürünAdı = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbox_acıklama = new System.Windows.Forms.TextBox();
            this.cmbox_ödeneYöntemi = new System.Windows.Forms.ComboBox();
            this.pnl_right.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_right
            // 
            this.pnl_right.BackColor = System.Drawing.Color.Silver;
            this.pnl_right.Controls.Add(this.listView1);
            this.pnl_right.Controls.Add(this.panel2);
            this.pnl_right.Controls.Add(this.flowLayoutPanel2);
            this.pnl_right.Controls.Add(this.flowLayoutPanel1);
            this.pnl_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_right.Location = new System.Drawing.Point(641, 0);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Size = new System.Drawing.Size(344, 570);
            this.pnl_right.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_ürün,
            this.columnHeader_miktar,
            this.columnHeader_fiyat});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(324, 375);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_ürün
            // 
            this.columnHeader_ürün.Text = "Ürün Adı";
            this.columnHeader_ürün.Width = 159;
            // 
            // columnHeader_miktar
            // 
            this.columnHeader_miktar.Text = "Miktar";
            this.columnHeader_miktar.Width = 89;
            // 
            // columnHeader_fiyat
            // 
            this.columnHeader_fiyat.Text = "Fiyat";
            this.columnHeader_fiyat.Width = 66;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_toplamTutar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btn_satış);
            this.panel2.Controls.Add(this.btn_temizle);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 375);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 195);
            this.panel2.TabIndex = 6;
            // 
            // lbl_toplamTutar
            // 
            this.lbl_toplamTutar.AutoSize = true;
            this.lbl_toplamTutar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_toplamTutar.Location = new System.Drawing.Point(221, 95);
            this.lbl_toplamTutar.Name = "lbl_toplamTutar";
            this.lbl_toplamTutar.Size = new System.Drawing.Size(41, 29);
            this.lbl_toplamTutar.TabIndex = 9;
            this.lbl_toplamTutar.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(18, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Toplam Tutar :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 10);
            this.panel4.TabIndex = 8;
            // 
            // btn_satış
            // 
            this.btn_satış.BackColor = System.Drawing.Color.Green;
            this.btn_satış.FlatAppearance.BorderSize = 0;
            this.btn_satış.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_satış.ForeColor = System.Drawing.Color.White;
            this.btn_satış.Location = new System.Drawing.Point(194, 148);
            this.btn_satış.Name = "btn_satış";
            this.btn_satış.Size = new System.Drawing.Size(124, 44);
            this.btn_satış.TabIndex = 4;
            this.btn_satış.Text = "Satış";
            this.btn_satış.UseVisualStyleBackColor = false;
            this.btn_satış.Click += new System.EventHandler(this.btn_satış_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.Red;
            this.btn_temizle.FlatAppearance.BorderSize = 0;
            this.btn_temizle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.Color.White;
            this.btn_temizle.Location = new System.Drawing.Point(23, 148);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(124, 44);
            this.btn_temizle.TabIndex = 4;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_ekle);
            this.panel5.Controls.Add(this.txtbox_miktar);
            this.panel5.Controls.Add(this.btn_sil);
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(324, 51);
            this.panel5.TabIndex = 8;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Blue;
            this.btn_ekle.FlatAppearance.BorderSize = 0;
            this.btn_ekle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Location = new System.Drawing.Point(244, 2);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(77, 44);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txtbox_miktar
            // 
            this.txtbox_miktar.Location = new System.Drawing.Point(14, 9);
            this.txtbox_miktar.Name = "txtbox_miktar";
            this.txtbox_miktar.Size = new System.Drawing.Size(64, 32);
            this.txtbox_miktar.TabIndex = 7;
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_sil.FlatAppearance.BorderSize = 0;
            this.btn_sil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Location = new System.Drawing.Point(168, 2);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(77, 44);
            this.btn_sil.TabIndex = 4;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(130, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 44);
            this.button6.TabIndex = 4;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(84, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 44);
            this.button5.TabIndex = 4;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 10);
            this.panel3.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(334, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(10, 570);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(10, 570);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(253, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Satış Ekranı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ürün Kodu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fiyat";
            // 
            // txtBox_fiyat
            // 
            this.txtBox_fiyat.Location = new System.Drawing.Point(417, 343);
            this.txtBox_fiyat.Name = "txtBox_fiyat";
            this.txtBox_fiyat.Size = new System.Drawing.Size(171, 32);
            this.txtBox_fiyat.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "KDV";
            // 
            // txtbox_ürünkod
            // 
            this.txtbox_ürünkod.Location = new System.Drawing.Point(417, 191);
            this.txtbox_ürünkod.Name = "txtbox_ürünkod";
            this.txtbox_ürünkod.Size = new System.Drawing.Size(171, 32);
            this.txtbox_ürünkod.TabIndex = 7;
            // 
            // txtbox_ürünkdv
            // 
            this.txtbox_ürünkdv.Location = new System.Drawing.Point(417, 269);
            this.txtbox_ürünkdv.Name = "txtbox_ürünkdv";
            this.txtbox_ürünkdv.Size = new System.Drawing.Size(171, 32);
            this.txtbox_ürünkdv.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Ürün Barkodu";
            // 
            // txtbox_ürünbarkod
            // 
            this.txtbox_ürünbarkod.Location = new System.Drawing.Point(121, 269);
            this.txtbox_ürünbarkod.Name = "txtbox_ürünbarkod";
            this.txtbox_ürünbarkod.Size = new System.Drawing.Size(171, 32);
            this.txtbox_ürünbarkod.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cari Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(413, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "Cari No";
            // 
            // txtbox_cariNo
            // 
            this.txtbox_cariNo.Location = new System.Drawing.Point(417, 111);
            this.txtbox_cariNo.Name = "txtbox_cariNo";
            this.txtbox_cariNo.Size = new System.Drawing.Size(171, 32);
            this.txtbox_cariNo.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(117, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 23);
            this.label11.TabIndex = 6;
            this.label11.Text = "Ödeme Yöntemi";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cmbox_cariAd
            // 
            this.cmbox_cariAd.FormattingEnabled = true;
            this.cmbox_cariAd.Location = new System.Drawing.Point(121, 111);
            this.cmbox_cariAd.Name = "cmbox_cariAd";
            this.cmbox_cariAd.Size = new System.Drawing.Size(171, 31);
            this.cmbox_cariAd.TabIndex = 8;
            this.cmbox_cariAd.SelectedIndexChanged += new System.EventHandler(this.cmbox_cariAd_SelectedIndexChanged);
            // 
            // cmbox_ürünAdı
            // 
            this.cmbox_ürünAdı.FormattingEnabled = true;
            this.cmbox_ürünAdı.Location = new System.Drawing.Point(118, 192);
            this.cmbox_ürünAdı.Name = "cmbox_ürünAdı";
            this.cmbox_ürünAdı.Size = new System.Drawing.Size(171, 31);
            this.cmbox_ürünAdı.TabIndex = 8;
            this.cmbox_ürünAdı.SelectedIndexChanged += new System.EventHandler(this.cmbox_ürünAdı_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Açıklama";
            // 
            // txtbox_acıklama
            // 
            this.txtbox_acıklama.Location = new System.Drawing.Point(118, 426);
            this.txtbox_acıklama.Multiline = true;
            this.txtbox_acıklama.Name = "txtbox_acıklama";
            this.txtbox_acıklama.Size = new System.Drawing.Size(456, 51);
            this.txtbox_acıklama.TabIndex = 7;
            // 
            // cmbox_ödeneYöntemi
            // 
            this.cmbox_ödeneYöntemi.FormattingEnabled = true;
            this.cmbox_ödeneYöntemi.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Çek",
            "Senet",
            "Borc "});
            this.cmbox_ödeneYöntemi.Location = new System.Drawing.Point(118, 344);
            this.cmbox_ödeneYöntemi.Name = "cmbox_ödeneYöntemi";
            this.cmbox_ödeneYöntemi.Size = new System.Drawing.Size(171, 31);
            this.cmbox_ödeneYöntemi.TabIndex = 8;
            this.cmbox_ödeneYöntemi.SelectedIndexChanged += new System.EventHandler(this.cmbox_ürünAdı_SelectedIndexChanged);
            // 
            // UC_Sales
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbox_ödeneYöntemi);
            this.Controls.Add(this.cmbox_ürünAdı);
            this.Controls.Add(this.cmbox_cariAd);
            this.Controls.Add(this.txtbox_acıklama);
            this.Controls.Add(this.txtBox_fiyat);
            this.Controls.Add(this.txtbox_ürünkdv);
            this.Controls.Add(this.txtbox_cariNo);
            this.Controls.Add(this.txtbox_ürünkod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbox_ürünbarkod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_right);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Name = "UC_Sales";
            this.Size = new System.Drawing.Size(985, 570);
            this.Load += new System.EventHandler(this.UC_Sales_Load);
            this.pnl_right.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_satış;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_miktar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_fiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_toplamTutar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtbox_ürünkod;
        private System.Windows.Forms.TextBox txtbox_ürünkdv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbox_ürünbarkod;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader_ürün;
        private System.Windows.Forms.ColumnHeader columnHeader_miktar;
        private System.Windows.Forms.ColumnHeader columnHeader_fiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbox_cariNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbox_cariAd;
        private System.Windows.Forms.ComboBox cmbox_ürünAdı;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbox_acıklama;
        private System.Windows.Forms.ComboBox cmbox_ödeneYöntemi;
    }
}
