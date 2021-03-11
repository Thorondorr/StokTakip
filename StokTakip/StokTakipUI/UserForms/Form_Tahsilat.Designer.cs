
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
            this.txtBox_kdv = new System.Windows.Forms.TextBox();
            this.txtBox_cariNo = new System.Windows.Forms.TextBox();
            this.txtBox_netfiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_stokEkle = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
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
            // txtBox_kdv
            // 
            this.txtBox_kdv.Location = new System.Drawing.Point(78, 207);
            this.txtBox_kdv.Name = "txtBox_kdv";
            this.txtBox_kdv.Size = new System.Drawing.Size(171, 32);
            this.txtBox_kdv.TabIndex = 68;
            // 
            // txtBox_cariNo
            // 
            this.txtBox_cariNo.Location = new System.Drawing.Point(362, 139);
            this.txtBox_cariNo.Name = "txtBox_cariNo";
            this.txtBox_cariNo.Size = new System.Drawing.Size(171, 32);
            this.txtBox_cariNo.TabIndex = 67;
            // 
            // txtBox_netfiyat
            // 
            this.txtBox_netfiyat.Location = new System.Drawing.Point(362, 207);
            this.txtBox_netfiyat.Name = "txtBox_netfiyat";
            this.txtBox_netfiyat.Size = new System.Drawing.Size(171, 32);
            this.txtBox_netfiyat.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 181);
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
            this.label11.Location = new System.Drawing.Point(358, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 23);
            this.label11.TabIndex = 58;
            this.label11.Text = "Ödenecek Tutar";
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
            // btn_stokEkle
            // 
            this.btn_stokEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_stokEkle.FlatAppearance.BorderSize = 0;
            this.btn_stokEkle.ForeColor = System.Drawing.Color.White;
            this.btn_stokEkle.Location = new System.Drawing.Point(362, 379);
            this.btn_stokEkle.Name = "btn_stokEkle";
            this.btn_stokEkle.Size = new System.Drawing.Size(177, 46);
            this.btn_stokEkle.TabIndex = 55;
            this.btn_stokEkle.Text = "Tahsil Et";
            this.btn_stokEkle.UseVisualStyleBackColor = false;
            this.btn_stokEkle.Click += new System.EventHandler(this.btn_stokEkle_Click);
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
            // Form_Tahsilat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(630, 571);
            this.ControlBox = false;
            this.Controls.Add(this.cmBox_cariAd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox_kdv);
            this.Controls.Add(this.txtBox_cariNo);
            this.Controls.Add(this.txtBox_netfiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_stokEkle);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Tahsilat";
            this.Text = "Form_Tahsilat";
            this.Load += new System.EventHandler(this.Form_Tahsilat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmBox_cariAd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBox_kdv;
        private System.Windows.Forms.TextBox txtBox_cariNo;
        private System.Windows.Forms.TextBox txtBox_netfiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_stokEkle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}