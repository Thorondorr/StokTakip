using Business.Concrete;
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

namespace StokTakipUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Authantiacition())
            {
                using (Form_Dashboard fd = new Form_Dashboard())
                {
                    fd.ShowDialog();
                }
            }
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {
            using (ParametreEkranı parametreEkranı = new ParametreEkranı())
            {
                parametreEkranı.ShowDialog();
            }
        }
        private bool Authantiacition()
        {
            KullanıcılarManager kullanıcılarManager = new KullanıcılarManager(new EfKullanıcıDal());
            var result = kullanıcılarManager.UserAutenticacion(new Kullanıcı
            {
                KullanıcıAdı = txtbox_kullanıcıAdı.Text,
                Sifre = txtBox_sifre.Text
            });

            if (result.Succes == true)
            {
                MessageBox.Show(result.Message);
            }
            else { MessageBox.Show(result.Message); }

            return result.Succes;
        }
    }
}
