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
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void btn_cariEkle_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_cariEkle);
        }

        private void btn_ürünekle_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_ürünekle);
        }

        private void btn_tahsilat_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_tahsilat);
        }

        private void btn_satıs_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_satıs);
        }

        private void btn_alış_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_alış);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lbl_timer.Text = dateTime.ToString("HH:MM:ss");
        }
    }
}
