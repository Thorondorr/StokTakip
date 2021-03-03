
namespace StokTakipUI.UserForms
{
    partial class Form_AddStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddStock));
            this.button1 = new System.Windows.Forms.Button();
            this.txtBox_kdv = new System.Windows.Forms.TextBox();
            this.txtBox_miktar = new System.Windows.Forms.TextBox();
            this.txtBox_ürünKodu = new System.Windows.Forms.TextBox();
            this.txtBox_netfiyat = new System.Windows.Forms.TextBox();
            this.txtBox_ürünAdı = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_stokEkle = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(662, 10);
            panel1.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(563, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 46);
            this.button1.TabIndex = 49;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBox_kdv
            // 
            this.txtBox_kdv.Location = new System.Drawing.Point(78, 307);
            this.txtBox_kdv.Name = "txtBox_kdv";
            this.txtBox_kdv.Size = new System.Drawing.Size(171, 32);
            this.txtBox_kdv.TabIndex = 48;
            // 
            // txtBox_miktar
            // 
            this.txtBox_miktar.Location = new System.Drawing.Point(374, 233);
            this.txtBox_miktar.Name = "txtBox_miktar";
            this.txtBox_miktar.Size = new System.Drawing.Size(171, 32);
            this.txtBox_miktar.TabIndex = 47;
            // 
            // txtBox_ürünKodu
            // 
            this.txtBox_ürünKodu.Location = new System.Drawing.Point(374, 153);
            this.txtBox_ürünKodu.Name = "txtBox_ürünKodu";
            this.txtBox_ürünKodu.Size = new System.Drawing.Size(171, 32);
            this.txtBox_ürünKodu.TabIndex = 46;
            // 
            // txtBox_netfiyat
            // 
            this.txtBox_netfiyat.Location = new System.Drawing.Point(374, 307);
            this.txtBox_netfiyat.Name = "txtBox_netfiyat";
            this.txtBox_netfiyat.Size = new System.Drawing.Size(171, 32);
            this.txtBox_netfiyat.TabIndex = 44;
            // 
            // txtBox_ürünAdı
            // 
            this.txtBox_ürünAdı.Location = new System.Drawing.Point(78, 153);
            this.txtBox_ürünAdı.Name = "txtBox_ürünAdı";
            this.txtBox_ürünAdı.Size = new System.Drawing.Size(171, 32);
            this.txtBox_ürünAdı.TabIndex = 42;
            this.txtBox_ürünAdı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_ürünAdı_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "KDV";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(370, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 23);
            this.label10.TabIndex = 38;
            this.label10.Text = "Ürün Kodu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "Miktar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(370, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 23);
            this.label11.TabIndex = 36;
            this.label11.Text = "Net Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(230, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 34);
            this.label2.TabIndex = 32;
            this.label2.Text = "Stok Ekle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 40;
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
            this.btn_stokEkle.TabIndex = 31;
            this.btn_stokEkle.Text = "Ekle";
            this.btn_stokEkle.UseVisualStyleBackColor = false;
            this.btn_stokEkle.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(652, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(10, 652);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 652);
            this.panel2.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 662);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(662, 10);
            this.panel3.TabIndex = 27;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 234);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 31);
            this.comboBox1.TabIndex = 50;
            // 
            // Form_AddStock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 672);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox_kdv);
            this.Controls.Add(this.txtBox_miktar);
            this.Controls.Add(this.txtBox_ürünKodu);
            this.Controls.Add(this.txtBox_netfiyat);
            this.Controls.Add(this.txtBox_ürünAdı);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_stokEkle);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_AddStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBox_kdv;
        private System.Windows.Forms.TextBox txtBox_miktar;
        private System.Windows.Forms.TextBox txtBox_ürünKodu;
        private System.Windows.Forms.TextBox txtBox_netfiyat;
        private System.Windows.Forms.TextBox txtBox_ürünAdı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_stokEkle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}