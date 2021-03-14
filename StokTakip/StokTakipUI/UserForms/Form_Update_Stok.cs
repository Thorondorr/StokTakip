using Business.Concrete;
using DataAcces.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipUI.UserForms
{
    public partial class Form_Update_Stok : Form
    {
        StokManager stokManager = new StokManager(new EfStokDal());
        CariManager cariManager = new CariManager(new EfCariDal());

        public Form_Update_Stok()
        {
            InitializeComponent();
            GetAllStok();
            getAllCariName();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_satınAl_Click(object sender, EventArgs e)
        {
            if (cmbox_ürünAdı.Text !="" && txtbox_kdv.Text != "" &&
                txtbox_ürünSayısı.Text != "" && txtbox_bürütFiyat.Text != "")
            {
                var result = stokManager.UrunGetByUrunKodu(txtBox_ürünkodu.Text);
                stokManager.Update(new Entity.Concrete.Stok
                {
                    CariNo = result.Data.CariNo,

                    KDV = Convert.ToInt32(txtbox_kdv.Text),
                    Miktar = Convert.ToInt32(txtbox_ürünSayısı.Text),
                    StokId = result.Data.StokId,
                    StokNetFiyatı = Convert.ToDecimal(txtbox_bürütFiyat.Text),
                    Tarih = DateTime.Now,
                    UrunAdı = result.Data.UrunAdı,
                    UrunKodu = result.Data.UrunKodu
                });

                MessageBox.Show("Stok Güncellendi.");
            }

            else
            {
                MessageBox.Show("Boş alanları doldurun.");
            }


        }

        private void Form_Add_Product_Load(object sender, EventArgs e)
        {

        }

        private void GetAllStok()
        {
            var result = stokManager.GetAll();
            foreach (var item in result.Data)
            {
                cmbox_ürünAdı.Items.Add(item.UrunAdı);
            }
        }

        private void getAllCariName()
        {
            var result = cariManager.GetAll();

            foreach (var item in result.Data)
            {
                // cmbox_CariAd.Items.Add(item.CariAdı);

            }
        }

        private void cmbox_CariAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = cariManager.GetAll();

            foreach (var item in result.Data)
            {
                //if (cmbox_CariAd.Text == item.CariAdı)
                //{
                //    txtbox_cariNo.Text = item.CariNo;
                //}

            }
        }

        private void cmbox_ürünAdı_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = stokManager.GetAll();
            foreach (var item in result.Data)
            {
                if (cmbox_ürünAdı.Text == item.UrunAdı)
                {
                    txtBox_ürünkodu.Text = item.UrunKodu;
                    txtbox_tarih.Text = DateTime.Now.ToString();
                    txtbox_kdv.Text = item.KDV.ToString();
                    txtbox_bürütFiyat.Text = item.StokNetFiyatı.ToString();
                    txtbox_ürünSayısı.Text = item.Miktar.ToString();

                }
            }
        }

        private void txtbox_kdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8  ))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void txtbox_ürünSayısı_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 ))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtbox_bürütFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isNumber(e.KeyChar, txtbox_bürütFiyat.Text))
                e.Handled = true;
        }
        public bool isNumber(char ch, string text)
        {
            bool res = true;
            char decimalChar = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            //check if it´s a decimal separator and if doesn´t already have one in the text string
            if (ch == decimalChar && text.IndexOf(decimalChar) != -1)
            {
                res = false;
                return res;
            }

            //check if it´s a digit, decimal separator and backspace
            if (!Char.IsDigit(ch) && ch != decimalChar && ch != (char)Keys.Back)
                res = false;

            return res;
        }
    }
}
