using Business.Concrete;
using Core.Entity;
using Core.Helper;
using DataAcces.Concrete;
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
    public partial class Form_Tahsilat : Form
    {
        CariManager cariManager = new CariManager(new EfCariDal());
        CariHareketlerManager carihareketManager = new CariHareketlerManager(new EfCariHareketDal());
        TahsilatManager tahsilatManager = new TahsilatManager(new EfTahsilatDal());
        TextBoxCFG txtBoxHelper = new TextBoxCFG();
        
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
            if (Convert.ToDecimal(txtBox_kalanBorc.Text) == 0)
            {
                MessageBox.Show("Borcunuz yoktur");
            }
            else
            {
                TahsilEt();
            }
        }

        private void TahsilEt()
        {
            Tahsilat tahsilat = new Tahsilat
            {
                BelgeNo = "M-" + System.Guid.NewGuid().ToString().Replace("-", "").ToUpper().ToString(),
                CariNo = txtBox_cariNo.Text,
                Tarih = DateTime.Now,
                Tip = cmbox_odemeTipi.Text,
                Tutar = Convert.ToDecimal(txtbox_odenecekTutar.Text)
            };

            var result = tahsilatManager.Add(tahsilat);
            carihareketManager.Add(new CariHareket
            {
                Aciklama = "Tahsilat işlemi.",
                BorcAlacak = "A",
                CariNo = txtBox_cariNo.Text,
                FaturaNo = tahsilat.BelgeNo,
                Tarih = DateTime.Now,
                Tutar = Convert.ToDecimal(txtbox_odenecekTutar.Text)
            });

            MessageBox.Show(result.Message);
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
                    txtBox_toplamBorc.Text=carihareketManager.GetAllBorcWithCariNo(item.CariNo).Data.ToString();
                    txtbox_odenenBorc.Text = carihareketManager.GetAllOdenenBorcWithCariNo(item.CariNo).Data.ToString();
                    txtBox_kalanBorc.Text = carihareketManager.GetAllKalanBorcWithCariNo(item.CariNo).Data.ToString();
                }

            }
        }

        private void txtbox_odenecekTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtBoxHelper.isNumber(e.KeyChar, txtbox_odenecekTutar.Text))
                e.Handled = true;
        }
    }
}
