using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserFormUI
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void FormGetir(Form form)
        {
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(form);
            form.Show();
        }

        private void btn_cariEkle_Click(object sender, EventArgs e)
        {
            Cari cariEkle = new Cari();
            FormGetir(cariEkle);
            
        }

        private void btn_ürünEkle_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle();
            FormGetir(urunEkle);
            
        }

        private  void CloseForm(string formName)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == formName || frm.Name=="Login")
                {
                    continue;
                }
                
            };
        }

        private void btn_tahsilat_Click(object sender, EventArgs e)
        {
            Tahsilat tahsilat = new Tahsilat();
            FormGetir(tahsilat);
        }

        private void btn_satış_Click(object sender, EventArgs e)
        {
            Satıs satıs = new Satıs();
            FormGetir(satıs);
        }

        private void btn_alış_Click(object sender, EventArgs e)
        {
            Alıs alıs = new Alıs();
            FormGetir(alıs);
        }
    }
}
