using Business.Concrete;
using DataAcces.Concrete.EntityFramework;
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
    public partial class UC_Stok : UserControl
    {
        StokManager stokManager = new StokManager(new EfStokDal());
        public UC_Stok()
        {
            InitializeComponent();
            RefleshDatagridView();
        }

        private void button_urunEkle_Click(object sender, EventArgs e)
        {
            using (Form_Update_Stok form_Add_Product = new Form_Update_Stok() )
            {
                form_Add_Product.ShowDialog();
                
            }
            RefleshDatagridView();
        }

        private void button_stokEkle_Click(object sender, EventArgs e)
        {
            using(Form_AddStokk form_AddStock = new Form_AddStokk())
            {
                form_AddStock.ShowDialog();
            }
            RefleshDatagridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefleshDatagridView()
        {
            var result = stokManager.GetAll();
            dataGridView1.DataSource = result.Data;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.Text == "Stok Adı")
            {
                var result = stokManager.GetByStokName(textBox1.Text);
                dataGridView1.DataSource = result.Data;
            }
        }
    }
}
