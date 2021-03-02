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
    public partial class UC_Purchase : UserControl
    {
        public UC_Purchase()
        {
            InitializeComponent();
        }

        private void button_urunEkle_Click(object sender, EventArgs e)
        {
            using (Form_Add_Product form_Add_Product = new Form_Add_Product() )
            {
                form_Add_Product.ShowDialog();
            }
        }
    }
}
