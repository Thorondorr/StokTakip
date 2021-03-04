using Business.Concrete;
using DataAcces.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipUI.UserForms
{
    public partial class ParametreEkranı : Form
    {
        //List<string> UserData;
        KullanıcılarManager kullanıcıManager = new KullanıcılarManager(new EfKullanıcıDal());
        public ParametreEkranı()
        {
            InitializeComponent();
            RefleshDataGridView();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanıcıManager.Add(new Kullanıcı
            {
                KullanıcıAdı = dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                Sifre = dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                Eposta = dataGridView1.CurrentRow.Cells[3].Value.ToString()
            });
            RefleshDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtBox_kullanıcıAdı.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBox_şifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtBox_eposta.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void RefleshDataGridView()
        {
            var result = kullanıcıManager.GetAll();
            dataGridView1.DataSource = result.Data;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            kullanıcıManager.Delete(new Kullanıcı
            {
                KullanıcıId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                KullanıcıAdı = dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                Sifre = dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                Eposta = dataGridView1.CurrentRow.Cells[3].Value.ToString()
            });
            txtBox_kullanıcıAdı.Text = "";
            txtBox_şifre.Text = "";
            txtBox_eposta.Text = "";
            RefleshDataGridView();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            kullanıcıManager.Update(new Kullanıcı
            {
                KullanıcıId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                KullanıcıAdı =txtBox_kullanıcıAdı.Text.ToString(),
                Sifre = txtBox_şifre.Text.ToString(),
                Eposta = txtBox_eposta.Text.ToString()
            });
            RefleshDataGridView();
        }
    }
}
