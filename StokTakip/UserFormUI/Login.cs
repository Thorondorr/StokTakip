﻿using Business.Concrete;
using DataAcces.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Windows.Forms;

namespace UserFormUI
{
    public partial class Login : Form
    {
        public bool LoginFormVisiblty { get; set; }
        
        public Login()
        {
            InitializeComponent();                       
        }
        
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            ParametreEkranıAc();
        }

        private void ParametreEkranıAc()
        {
            ParametreEkranı parametreEkranı = new ParametreEkranı();
            parametreEkranı.Show();
            this.Hide();                                                       
        }

        

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           var result = Authantiacition();
            if (result) { AnaMenu anaMenu = new AnaMenu();
                anaMenu.Show();
            }
        }

        private bool Authantiacition()
        {
            KullanıcılarManager kullanıcılarManager = new KullanıcılarManager(new EfKullanıcıDal());
            var result = kullanıcılarManager.UserAutenticacion(new Kullanıcı
            {
                KullanıcıAdı = txtBox_kullanıcıAdı.Text,
                Sifre = txtBox_Sifre.Text
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
