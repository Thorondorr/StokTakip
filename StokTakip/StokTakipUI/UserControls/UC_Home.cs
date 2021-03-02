using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipUI.UserControls
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            lbl_alıs.Text = random.Next(0, 100).ToString();
            lbl_satıs.Text=random.Next(0, 100).ToString();
            label6.Text = random.Next(0, 100).ToString();
        }
        private void AddControlsToPanel(Control c)
        {
           
            
        }
    }
}
