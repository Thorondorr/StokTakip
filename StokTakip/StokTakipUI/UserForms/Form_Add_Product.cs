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
    public partial class Form_Add_Product : Form
    {
        StokManager stokManager = new StokManager(new EfStokDal());
        CariManager cariManager = new CariManager(new EfCariDal());
        
        public Form_Add_Product()
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
            var result = stokManager.UrunGetByUrunKodu(txtBox_ürünkodu.Text);
            stokManager.Update(new Entity.Concrete.Stok
            {
                CariNo=result.Data.CariNo,
               
                KDV=Convert.ToInt32(txtbox_kdv.Text),
                Miktar=Convert.ToInt32(txtbox_ürünSayısı.Text),
                StokId=result.Data.StokId,
                StokNetFiyatı=Convert.ToDecimal(txtbox_bürütFiyat.Text),
                Tarih=DateTime.Now,
                UrunAdı=result.Data.UrunAdı,
                UrunKodu=result.Data.UrunKodu
            });
            
        }

        private void Form_Add_Product_Load(object sender, EventArgs e)
        {

        }

        private void GetAllStok()
        {
           var result =  stokManager.GetAll();
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
                cmbox_CariAd.Items.Add(item.CariAdı);
                
            }
        }

        private void cmbox_CariAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = cariManager.GetAll();

            foreach (var item in result.Data)
            {
                if (cmbox_CariAd.Text == item.CariAdı)
                {
                    txtbox_cariNo.Text = item.CariNo;
                }

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
    }
}
