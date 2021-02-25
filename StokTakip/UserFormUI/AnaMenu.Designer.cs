namespace UserFormUI
{
    partial class AnaMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_alış = new System.Windows.Forms.Button();
            this.btn_satış = new System.Windows.Forms.Button();
            this.btn_tahsilat = new System.Windows.Forms.Button();
            this.btn_ürünEkle = new System.Windows.Forms.Button();
            this.btn_cariEkle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_alış);
            this.panel1.Controls.Add(this.btn_satış);
            this.panel1.Controls.Add(this.btn_tahsilat);
            this.panel1.Controls.Add(this.btn_ürünEkle);
            this.panel1.Controls.Add(this.btn_cariEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 88);
            this.panel1.TabIndex = 0;
            // 
            // btn_alış
            // 
            this.btn_alış.Location = new System.Drawing.Point(796, 22);
            this.btn_alış.Name = "btn_alış";
            this.btn_alış.Size = new System.Drawing.Size(190, 46);
            this.btn_alış.TabIndex = 0;
            this.btn_alış.Text = "Alış";
            this.btn_alış.UseVisualStyleBackColor = true;
            // 
            // btn_satış
            // 
            this.btn_satış.Location = new System.Drawing.Point(600, 22);
            this.btn_satış.Name = "btn_satış";
            this.btn_satış.Size = new System.Drawing.Size(190, 46);
            this.btn_satış.TabIndex = 0;
            this.btn_satış.Text = "Satış";
            this.btn_satış.UseVisualStyleBackColor = true;
            // 
            // btn_tahsilat
            // 
            this.btn_tahsilat.Location = new System.Drawing.Point(404, 22);
            this.btn_tahsilat.Name = "btn_tahsilat";
            this.btn_tahsilat.Size = new System.Drawing.Size(190, 46);
            this.btn_tahsilat.TabIndex = 0;
            this.btn_tahsilat.Text = "Tahsilat";
            this.btn_tahsilat.UseVisualStyleBackColor = true;
            // 
            // btn_ürünEkle
            // 
            this.btn_ürünEkle.Location = new System.Drawing.Point(208, 22);
            this.btn_ürünEkle.Name = "btn_ürünEkle";
            this.btn_ürünEkle.Size = new System.Drawing.Size(190, 46);
            this.btn_ürünEkle.TabIndex = 0;
            this.btn_ürünEkle.Text = "Ürün Ekle";
            this.btn_ürünEkle.UseVisualStyleBackColor = true;
            this.btn_ürünEkle.Click += new System.EventHandler(this.btn_ürünEkle_Click);
            // 
            // btn_cariEkle
            // 
            this.btn_cariEkle.Location = new System.Drawing.Point(12, 22);
            this.btn_cariEkle.Name = "btn_cariEkle";
            this.btn_cariEkle.Size = new System.Drawing.Size(190, 46);
            this.btn_cariEkle.TabIndex = 0;
            this.btn_cariEkle.Text = "Cari Ekle";
            this.btn_cariEkle.UseVisualStyleBackColor = true;
            this.btn_cariEkle.Click += new System.EventHandler(this.btn_cariEkle_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 527);
            this.panel2.TabIndex = 2;
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "AnaMenu";
            this.Text = "AnaMenu";
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_alış;
        private System.Windows.Forms.Button btn_satış;
        private System.Windows.Forms.Button btn_tahsilat;
        private System.Windows.Forms.Button btn_ürünEkle;
        private System.Windows.Forms.Button btn_cariEkle;
        private System.Windows.Forms.Panel panel2;
    }
}