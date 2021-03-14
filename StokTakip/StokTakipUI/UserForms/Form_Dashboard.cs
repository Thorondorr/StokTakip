using StokTakipUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipUI
{
    public partial class Form_Dashboard : Form
    {
        int _panelWidht;
        bool _isCollapsed;
        public Form_Dashboard()
        {
            InitializeComponent();
            moveSidePanel(btn_home);
            UserControls.UC_Home uC_Home = new UserControls.UC_Home();
            AddControlsToPanel(uC_Home);

            timer2.Start();
            _panelWidht = panelLeft.Width;
            _isCollapsed = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width>=_panelWidht)
                {
                    timer1.Stop();
                    _isCollapsed = false;
                    this.Refresh();
                }
                
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 60)
                {
                    timer1.Stop();
                    _isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_home);
            UserControls.UC_Home uC_Home = new UserControls.UC_Home();
            AddControlsToPanel(uC_Home);
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void btn_cariEkle_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_cariEkle);
            UC_Sales uC_Sales = new UC_Sales();
            AddControlsToPanel(uC_Sales);
        }

        private void btn_ürünekle_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_ürünekle);
            UC_Stok uC_Purchase = new UC_Stok();
            AddControlsToPanel(uC_Purchase);

        }

        private void btn_tahsilat_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_tahsilat);
            UC_Tahsilat uC_Tahsilat = new UC_Tahsilat();
            AddControlsToPanel(uC_Tahsilat);
        }

        private void btn_satıs_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_satıs);
            UC_Customer_Add customer_Add = new UC_Customer_Add();
            AddControlsToPanel(customer_Add);
        }
  

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lbl_timer.Text = dateTime.ToString("HH:MM:ss");
        }

        private void panelControls_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            moveSidePanel(btn_alıs);
            UC_Purchase uC_Purchase = new UC_Purchase();
            AddControlsToPanel(uC_Purchase);
        }

        private void btn_fatura_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_fatura);
            UC_Fatura uC_Fatura = new UC_Fatura();
            AddControlsToPanel(uC_Fatura);
        }
    }
}
