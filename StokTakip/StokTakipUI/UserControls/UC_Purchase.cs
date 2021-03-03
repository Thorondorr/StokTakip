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
    public partial class UC_Purchase : UserControl
    {
        StokManager stokManager = new StokManager(new EfStokDal());
        public UC_Purchase()
        {
            InitializeComponent();
            RefleshDatagridView();
        }

        private void button_urunEkle_Click(object sender, EventArgs e)
        {
            using (Form_Add_Product form_Add_Product = new Form_Add_Product() )
            {
                form_Add_Product.ShowDialog();
            }
        }

        private void button_stokEkle_Click(object sender, EventArgs e)
        {
            using(Form_AddStock form_AddStock = new Form_AddStock())
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
    }
}
