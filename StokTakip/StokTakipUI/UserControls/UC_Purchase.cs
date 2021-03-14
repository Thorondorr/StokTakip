using Business.Concrete;
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

namespace StokTakipUI.UserControls
{
    public partial class UC_Purchase : UserControl
    {
        CariManager cariManager = new CariManager(new EfCariDal());
        UrunManager urunManager = new UrunManager(new EfUrunDal());
        FaturaManager faturaManager = new FaturaManager(new EfFaturaDal(), new CariHareketlerManager(new EfCariHareketDal()));
        StokManager stokManager = new StokManager(new EfStokDal());
        TahsilatManager tahsilatManager = new TahsilatManager(new EfTahsilatDal());
        CariHareketlerManager cariHareketManager = new CariHareketlerManager(new EfCariHareketDal());
        StokHareketManager stokHareket = new StokHareketManager(new EfStokHareketDal());
        TediyeManager tediyeManager = new TediyeManager(new EfTediyeDal());

        List<Sepet> sepets = new List<Sepet>();

        TextBoxCFG txtBoxCFG = new TextBoxCFG();
        public UC_Purchase()
        {
            InitializeComponent();
            addComboxToCariAd();
        }

        private void btn_satış_Click(object sender, EventArgs e)
        {
            string faturaNo = faturaManager.CreateFaturaNoWithGUID().Message;//bir sepet için 1 adet fatura no üretir

            for (int i = 0; i < sepets.Count; i++)
            {

                var result = faturaManager.CreateAlisFatura(sepets[i], faturaNo);
                //her fatura kestiğinde stokğu güncelle

                //stokManager.UpdateStokQuantity(sepets[i], sepets[i].Miktar); // eğer stok 
                sepets[i].FaturaNo = result.Data.FaturaNo;
                stokManager.AddPurchasedNewStok(sepets[i]);
                stokHareket.Giris(sepets[i]);
                cariHareketManager.BorcCreateCariHareket(result.Data.FaturaNo, sepets[i]);
                urunManager.AddUrunFromSepet(sepets[i]);

            }
            txtbox_acıklama.Clear();
            txtbox_cariNo.Clear();
            txtBox_fiyat.Clear();
            txtbox_miktar.Text = "0";
            // txtbox_ürünbarkod.Clear();
            txtbox_ürünkdv.Clear();
            txtbox_ürünkod.Clear();
            lbl_toplamTutar.Text = "0";
            cmbox_cariAd.Text = "";
            //cmbox_ödeneYöntemi.Text = "";
            txtbx_urunAdı.Text = "";
            listView1.Items.Clear();
            sepets.Clear();

            MessageBox.Show("Satış gerçekleşti.");

        }
        private void addComboxToCariAd()
        {
            var result = cariManager.GetAll();

            foreach (var item in result.Data)
            {
                cmbox_cariAd.Items.Add(item.CariAdı);
            }
        }

        private void cmbox_cariAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = cariManager.GetAll();

            foreach (var item in result.Data)
            {
                if (cmbox_cariAd.Text == item.CariAdı)
                {
                    txtbox_cariNo.Text = item.CariNo;
                }

            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            Sepet sepet = new Sepet
            {
                CariNo = txtbox_cariNo.Text,
                Aciklama = txtbox_acıklama.Text,
                UrunAdı = txtbx_urunAdı.Text,
                UrunKodu = txtbox_ürünkod.Text,
                Barkot = urunManager.CreateBarkot().Message,
                KDV = Convert.ToInt32(txtbox_ürünkdv.Text),
                Miktar = Convert.ToInt32(txtbox_miktar.Text),
                Fiyat = (Convert.ToDecimal(txtBox_fiyat.Text) + ((Convert.ToDecimal(txtbox_ürünkdv.Text) * Convert.ToInt32(txtBox_fiyat.Text)) / 100)) * Convert.ToInt32(txtbox_miktar.Text),
                BürütTutar = Convert.ToDecimal(txtbox_miktar.Text) * Convert.ToDecimal(txtBox_fiyat.Text),
                UrunTipi = txtbox_urunTipi.Text

            };

            addToListView(sepet.UrunAdı, sepet.Miktar.ToString(), sepet.Fiyat.ToString());
            sepets.Add(sepet);
            decimal toplamTutar = 0;

            for (int i = 0; i < sepets.Count; i++)
            {
                toplamTutar += toplamTutar = sepets[i].Fiyat;
            }
            lbl_toplamTutar.Text = toplamTutar.ToString();
        }

        private void UC_Purchase_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            txtbox_miktar.Text = "0";
        }
        private void addToListView(string urunAdı, string miktar, string fiyat)
        {
            String[] row = { urunAdı, miktar, fiyat };

            ListViewItem listViewItem = new ListViewItem(row);

            listView1.Items.Add(listViewItem);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtbox_miktar.Text) < 0)
            {
                txtbox_miktar.Text = "1";
            }
            else
            {
                txtbox_miktar.Text = (Convert.ToInt32(txtbox_miktar.Text) + 1).ToString();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(txtbox_miktar.Text) <= 0)
            {
                txtbox_miktar.Text = "0";
            }
            else
            {
                txtbox_miktar.Text = (Convert.ToInt32(txtbox_miktar.Text) - 1).ToString();
            }

        }

        private void txtbox_ürünkdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtBox_fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtBoxCFG.isNumber(e.KeyChar, txtBox_fiyat.Text))
                e.Handled = true;
        }

        private void txtbox_miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
