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

namespace StokTakipUI.UserForms
{
    public partial class Form_Tahsilat : Form
    {
        CariManager cariManager = new CariManager(new EfCariDal());
        public Form_Tahsilat()
        {
            InitializeComponent();
        }

        private void Form_Tahsilat_Load(object sender, EventArgs e)
        {
            cariCmBoxLoad();
        }

        private void btn_stokEkle_Click(object sender, EventArgs e)
        {
            
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cariCmBoxLoad()
        {
            var result = cariManager.GetAll();

            foreach (var cari in result.Data)
            {
                cmBox_cariAd.Items.Add(cari.CariAdı);
            }
        }

        private void cmBox_cariAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = cariManager.GetAll();

            foreach (var item in result.Data)
            {
                if (cmBox_cariAd.Text == item.CariAdı)
                {
                    txtBox_cariNo.Text = item.CariNo;
                }

            }
        }
    }
}
