using Business.Concrete;
using DataAcces.Concrete.EntityFramework;
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
    public partial class UC_Fatura : UserControl
    {
        FaturaManager faturaManager = new FaturaManager(new EfFaturaDal(), new CariHareketlerManager(new EfCariHareketDal()));
        public UC_Fatura()
        {
            InitializeComponent();
            ReflashDataGridView();
            dateTimePicker1.Visible = false;
        }

        

        private void ReflashDataGridView()
        {
            var result = faturaManager.GetAll();
            dataGridView1.DataSource = result.Data;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (comboBox1.Text == "Stok Adı") 
            {

                var result = faturaManager.SearchGetByStokAd(textBox1.Text);
                dataGridView1.DataSource = result.Data;
            }
            if (comboBox1.Text == "Cari No")
            {

                var result = faturaManager.SearchGetByCariNo(textBox1.Text);
                dataGridView1.DataSource = result.Data;
            }
            if (comboBox1.Text == "Fatura Tip")
            {

                var result = faturaManager.SearchGetByFaturaTipi(textBox1.Text);
                dataGridView1.DataSource = result.Data;
            }
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bütün Faturalar")
            {
                ReflashDataGridView();
            }
            if (comboBox1.Text == "Tarih")
            {
                dateTimePicker1.Visible = true;
            }
            else
            {
                dateTimePicker1.Visible = false;
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var result = faturaManager.SearchByTarih(dateTimePicker1.Value.Date);
            dataGridView1.DataSource = result.Data;
        }
    }
}
