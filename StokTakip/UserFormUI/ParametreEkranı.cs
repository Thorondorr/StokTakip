using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Concrete;
using DataAcces.Concrete.EntityFramework;
using Entity.Concrete;

namespace UserFormUI
{
    public partial class ParametreEkranı : Form
    {
        KullanıcılarManager kullanıcılarManager = new KullanıcılarManager(new EfKullanıcıDal());
        public ParametreEkranı()
        {
            InitializeComponent();
            RefleshDataGridView();

        }

        private void ParametreEkranı_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginScreenShow();

        }

        private static void LoginScreenShow()
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "Login")
                {
                    frm.Show();
                }
            };
        }

        private void ParametreEkranı_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanıcılarManager.Add(new Kullanıcı { 
                KullanıcıAdı = txtbox_kullanıcıAdı.Text,
                Sifre=txtbox_sifre.Text,
                Eposta=txtbox_email.Text
                });
            RefleshDataGridView();
        }
        private void RefleshDataGridView()
        {
            var result = kullanıcılarManager.GetAll();
            dataGridView_parametreEkranı.DataSource = result.Data;
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            kullanıcılarManager.Update(new Kullanıcı
            {
                KullanıcıId=Convert.ToInt32(txtbox_kullanıcıId.Text),
                KullanıcıAdı = txtbox_kullanıcıAdı.Text,
                Sifre = txtbox_sifre.Text,
                Eposta = txtbox_email.Text
            });
            RefleshDataGridView();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            kullanıcılarManager.Delete(new Kullanıcı
            {
                KullanıcıId = Convert.ToInt32(txtbox_kullanıcıId.Text),
                KullanıcıAdı = txtbox_kullanıcıAdı.Text,
                Sifre = txtbox_sifre.Text,
                Eposta = txtbox_email.Text
            });
            RefleshDataGridView();
        }

        private void dataGridView_parametreEkranı_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbox_kullanıcıId.Text=dataGridView_parametreEkranı.CurrentRow.Cells[0].Value.ToString();
            txtbox_kullanıcıAdı.Text = dataGridView_parametreEkranı.CurrentRow.Cells[1].Value.ToString();
            txtbox_sifre.Text = dataGridView_parametreEkranı.CurrentRow.Cells[2].Value.ToString();
            txtbox_email.Text = dataGridView_parametreEkranı.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
