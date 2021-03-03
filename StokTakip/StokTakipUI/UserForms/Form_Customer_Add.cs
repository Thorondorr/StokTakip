﻿using Business.Concrete;
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

namespace StokTakipUI.UserForms
{
    public partial class Form_Customer_Add : Form
    {
        CariManager cari = new CariManager(new EfCariDal());
        public Form_Customer_Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          var result= cari.Add(new Entity.Concrete.Cari
            {
                CariAdı = txtbox_cariAdı.Text,
                CariAdres = txtbox_cariAdres.Text,
                CariIl = txtbox_cariiL.Text,
                CariIlce = txtbox_cariilçe.Text,               
                Eposta = txtbox_ePosta.Text,
                TcKimlikNo = txtbox_tcKimlikNo.Text,
                Telefon = txtbox_telefon.Text,
                VergiDairesi = txtbox_vergiDairesi.Text,
                VergiNo = txtbox_VergiNo.Text
            });

            MessageBox.Show(result.Message);
        }
    }
}
