using Business.Concrete;
using Core.Helper;
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
    public partial class Form_AddStokk : Form
    {
        StokHareketManager stokHareketManager = new StokHareketManager(new EfStokHareketDal());
        StokManager stokManager = new StokManager(new EfStokDal());
        CariManager cariManager = new CariManager(new EfCariDal());
        UrunManager UrunManager = new UrunManager(new EfUrunDal());
        Random random = new Random();

        TextBoxCFG textBoxCFG = new TextBoxCFG();
        public Form_AddStokk()
        {
            InitializeComponent();
            getCariAdd();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void getCariAdd()
        {
          var resul= cariManager.GetAll();
            foreach(var a in resul.Data)
            {
                comboBox1.Items.Add(a.CariAdı);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var result = cariManager.Search(new Cari
            {
                CariAdı = comboBox1.Text
            });


            Stok stok = new Stok
            {
                UrunAdı = txtBox_ürünAdı.Text,
                UrunKodu = txtBox_ürünKodu.Text.ToString(),
                CariNo = "",
                KDV = Convert.ToInt32(txtBox_kdv.Text),
                Miktar = Convert.ToInt32(txtBox_miktar.Text),
                StokNetFiyatı = Convert.ToInt32(txtBox_netfiyat.Text),
                Tarih = DateTime.Now
            };

            foreach (var item in result.Data)
            {
                stok.CariNo = item.CariNo;
            }

            var result1 = stokManager.Add(stok);

            var result2 = stokManager.GetByUrunAdı(stok.UrunAdı).Data;

            Urun urun = new Urun
            {
                Barkot = random.Next(0, 100).ToString(),
                Fiyat = stok.StokNetFiyatı,
                KDV = stok.KDV,
                Miktar = stok.Miktar,
                UrunAdı = stok.UrunAdı,
                UrunTipi = txtbox_ürünTürü.Text,
                UrunKodu = result2.UrunKodu,
            };

            UrunManager.Add(urun);

            if (result1.Succes)
            {
                MessageBox.Show(result1.Message);
               
            }
            else
            {
                MessageBox.Show(result1.Message);
            }

        }

        private void txtBox_miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtBox_netfiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!textBoxCFG.isNumber(e.KeyChar, txtBox_netfiyat.Text))
                e.Handled = true;
        }

        private void txtBox_kdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 ))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
