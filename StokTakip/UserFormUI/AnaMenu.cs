using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserFormUI
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CariTanımla cariTanımla = new CariTanımla();
            cariTanımla.MdiParent = this;
            cariTanımla.Show();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void grpBox_menu_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            UrunTanimla urunTanimla = new UrunTanimla();
            urunTanimla.MdiParent = this;
            urunTanimla.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(urunTanimla);
            urunTanimla.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
