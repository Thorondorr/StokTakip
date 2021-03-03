using Business.Concrete;
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
using DataAcces.Concrete.EntityFramework;

namespace StokTakipUI.UserControls
{
    public partial class UC_Customer_Add : UserControl
    {
        CariManager cari = new CariManager(new EfCariDal());
        public UC_Customer_Add()
        {
            InitializeComponent();
            RefleshDatagridView();
        }

        private void button_urunEkle_Click(object sender, EventArgs e)
        {
            using (Form_Customer_Add customer_Add = new Form_Customer_Add())
            {
                customer_Add.ShowDialog();

            }
            RefleshDatagridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefleshDatagridView()
        {
           var result = cari.GetAll();
            dataGridView1.DataSource = result.Data;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(comboBox1.Text== "Cari Adı")
            {
                var result = cari.Search(new Entity.Concrete.Cari
                {
                    CariAdı = textBox1.Text
                });
                
                dataGridView1.DataSource = result.Data;
            }
          
        }
    }
}
