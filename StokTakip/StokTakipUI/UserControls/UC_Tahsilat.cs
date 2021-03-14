using Business.Concrete;
using DataAcces.Concrete;
using DataAcces.Concrete.EntityFramework;
using Entity.Concrete;
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
    public partial class UC_Tahsilat : UserControl
    {
        TahsilatManager tahsilatManager = new TahsilatManager(new EfTahsilatDal());
        CariHareketlerManager CariHareketlerManager = new CariHareketlerManager(new EfCariHareketDal());
        CariManager CariManager = new CariManager(new EfCariDal());
        public UC_Tahsilat()
        {
            InitializeComponent();
            //RefleshDataGridView();
            //createDataGridViewColumn();
            getTahsilats();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(comboBox1.Text == "Cari No")
            {
                var result = tahsilatManager.GetByCariNo(textBox1.Text);
                dataGridView1.DataSource = result.Data;
            }
            
        }

        private void button_urunEkle_Click(object sender, EventArgs e)
        {
            using (Form_Tahsilat form_Tahsilat = new Form_Tahsilat())
            {
                form_Tahsilat.ShowDialog();
            }
        }

        //datagrid view
        private void createDataGridViewColumn()
        {
          
            


        }
        private void RefleshDataGridView()
        {
            var result = tahsilatManager.GetTahsilatDetails();
            dataGridView1.DataSource = result.Data;
        }
        private void getTahsilats()
        {
            var result = tahsilatManager.GetAll();
            dataGridView1.DataSource = result.Data;
        }
    }
}
