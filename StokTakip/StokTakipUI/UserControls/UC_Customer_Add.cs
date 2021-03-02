using StokTakipUI.UserForms;
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
    public partial class UC_Customer_Add : UserControl
    {
        public UC_Customer_Add()
        {
            InitializeComponent();
        }

        private void button_urunEkle_Click(object sender, EventArgs e)
        {
            using (Form_Customer_Add customer_Add = new Form_Customer_Add())
            {
                customer_Add.ShowDialog();
            }
        }
    }
}
