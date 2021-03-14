
namespace StokTakipUI.UserForms
{
    partial class Form_Tahsilat
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
            System.Windows.Forms.Panel panel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Tahsilat));
            this.cmBox_cariAd = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBox_toplamBorc = new System.Windows.Forms.TextBox();
            this.txtBox_cariNo = new System.Windows.Forms.TextBox();
            this.txtBox_kalanBorc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_tahsilEt = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_odenenBorc = new System.Windows.Forms.TextBox();
            this.txtbox_odenecekTutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbox_odemeTipi = new System.Windows.Forms.ComboBox();
            panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(630, 10);
            panel1.TabIndex = 52;
            // 
            // cmBox_cariAd
            // 
            this.cmBox_cariAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBox_cariAd.FormattingEnabled = true;
            this.cmBox_cariAd.Location = new System.Drawing.Point(78, 140);
            this.cmBox_cariAd.Name = "cmBox_cariAd";
            this.cmBox_cariAd.Size = new System.Drawing.Size(171, 31);
            this.cmBox_cariAd.TabIndex = 71;
            this.cmBox_cariAd.SelectedIndexChanged += new System.EventHandler(this.cmBox_cariAd_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(545, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 46);
            this.button1.TabIndex = 70;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBox_toplamBorc
            // 
            this.txtBox_toplamBorc.Enabled = false;
            this.txtBox_toplamBorc.Location = new System.Drawing.Point(78, 215);
            this.txtBox_toplamBorc.Name = "txtBox_toplamBorc";
            this.txtBox_toplamBorc.Size = new System.Drawing.Size(171, 32);
            this.txtBox_toplamBorc.TabIndex = 68;
            // 
            // txtBox_cariNo
            // 
            this.txtBox_cariNo.Enabled = false;
            this.txtBox_cariNo.Location = new System.Drawing.Point(362, 139);
            this.txtBox_cariNo.Name = "txtBox_cariNo";
            this.txtBox_cariNo.Size = new System.Drawing.Size(171, 32);
            this.txtBox_cariNo.TabIndex = 67;
            // 
            // txtBox_kalanBorc
            // 
            this.txtBox_kalanBorc.Enabled = false;
            this.txtBox_kalanBorc.Location = new System.Drawing.Point(78, 295);
            this.txtBox_kalanBorc.Name = "txtBox_kalanBorc";
            this.txtBox_kalanBorc.Size = new System.Drawing.Size(455, 32);
            this.txtBox_kalanBorc.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 23);
            this.label5.TabIndex = 62;
            this.label5.Text = "Toplam Borcu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 59;
            this.label6.Text = "Cari No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 23);
            this.label11.TabIndex = 58;
            this.label11.Text = "Kalan Borç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(230, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 34);
            this.label2.TabIndex = 56;
            this.label2.Text = "Tahsilat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 63;
            this.label1.Text = "Cari Ad";
            // 
            // btn_tahsilEt
            // 
            this.btn_tahsilEt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_tahsilEt.FlatAppearance.BorderSize = 0;
            this.btn_tahsilEt.ForeColor = System.Drawing.Color.White;
            this.btn_tahsilEt.Location = new System.Drawing.Point(362, 480);
            this.btn_tahsilEt.Name = "btn_tahsilEt";
            this.btn_tahsilEt.Size = new System.Drawing.Size(177, 46);
            this.btn_tahsilEt.TabIndex = 55;
            this.btn_tahsilEt.Text = "Tahsil Et";
            this.btn_tahsilEt.UseVisualStyleBackColor = false;
            this.btn_tahsilEt.Click += new System.EventHandler(this.btn_stokEkle_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(620, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(10, 551);
            this.flowLayoutPanel1.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 551);
            this.panel2.TabIndex = 53;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 561);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 10);
            this.panel3.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 62;
            this.label3.Text = "Ödenen Borç";
            // 
            // txtbox_odenenBorc
            // 
            this.txtbox_odenenBorc.Enabled = false;
            this.txtbox_odenenBorc.Location = new System.Drawing.Point(356, 215);
            this.txtbox_odenenBorc.Name = "txtbox_odenenBorc";
            this.txtbox_odenenBorc.Size = new System.Drawing.Size(171, 32);
            this.txtbox_odenenBorc.TabIndex = 68;
            // 
            // txtbox_odenecekTutar
            // 
            this.txtbox_odenecekTutar.Location = new System.Drawing.Point(362, 367);
            this.txtbox_odenecekTutar.Name = "txtbox_odenecekTutar";
            this.txtbox_odenecekTutar.Size = new System.Drawing.Size(171, 32);
            this.txtbox_odenecekTutar.TabIndex = 73;
            this.txtbox_odenecekTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_odenecekTutar_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 23);
            this.label4.TabIndex = 72;
            this.label4.Text = "Ödenecek Tutar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 23);
            this.label7.TabIndex = 63;
            this.label7.Text = "Ödeme Türü";
            // 
            // cmbox_odemeTipi
            // 
            this.cmbox_odemeTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_odemeTipi.FormattingEnabled = true;
            this.cmbox_odemeTipi.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı"});
            this.cmbox_odemeTipi.Location = new System.Drawing.Point(79, 367);
            this.cmbox_odemeTipi.Name = "cmbox_odemeTipi";
            this.cmbox_odemeTipi.Size = new System.Drawing.Size(171, 31);
            this.cmbox_odemeTipi.TabIndex = 71;
            this.cmbox_odemeTipi.SelectedIndexChanged += new System.EventHandler(this.cmBox_cariAd_SelectedIndexChanged);
            // 
            // Form_Tahsilat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(630, 571);
            this.ControlBox = false;
            this.Controls.Add(this.txtbox_odenecekTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbox_odemeTipi);
            this.Controls.Add(this.cmBox_cariAd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbox_odenenBorc);
            this.Controls.Add(this.txtBox_toplamBorc);
            this.Controls.Add(this.txtBox_cariNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_kalanBorc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_tahsilEt);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Tahsilat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Tahsilat";
            this.Load += new System.EventHandler(this.Form_Tahsilat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmBox_cariAd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBox_toplamBorc;
        private System.Windows.Forms.TextBox txtBox_cariNo;
        private System.Windows.Forms.TextBox txtBox_kalanBorc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tahsilEt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_odenenBorc;
        private System.Windows.Forms.TextBox txtbox_odenecekTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbox_odemeTipi;
    }
}