using Business.Concrete;
using DataAcces.Abstract;
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
    public partial class UC_Sales : UserControl
    {
        CariManager cariManager = new CariManager(new EfCariDal());
        UrunManager urunManager = new UrunManager(new EfUrunDal());
        FaturaManager faturaManager = new FaturaManager(new EfFaturaDal(), new CariHareketlerManager(new EfCariHareketDal()));
        StokManager stokManager = new StokManager(new EfStokDal());
        TahsilatManager tahsilatManager = new TahsilatManager(new EfTahsilatDal());
        CariHareketlerManager cariHareketManager = new CariHareketlerManager(new EfCariHareketDal());
        StokHareketManager stokHareket = new StokHareketManager(new EfStokHareketDal());

        //List<Urun> uruns = new List<Urun>();
        public List<Sepet> sepets = new List<Sepet>();

        ListView ListView = new ListView();
        public UC_Sales()
        {
            InitializeComponent();
            addCmboxToUrunAdi();
            addComboxToCariAd();
        }

        private void UC_Sales_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            txtbox_miktar.Text = "0";

            //listView1.Columns.Add("Ürün Adı",159);
            //listView1.Columns.Add("Miktar",89);
            //listView1.Columns.Add("Fiyat",66);



        }

        private void addToListView(string urunAdı, string miktar, string fiyat)
        {
            String[] row = { urunAdı, miktar, fiyat };

            ListViewItem listViewItem = new ListViewItem(row);

            listView1.Items.Add(listViewItem);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void addComboxToCariAd()
        {
            var result = cariManager.GetAll();

            foreach (var item in result.Data)
            {
                cmbox_cariAd.Items.Add(item.CariAdı);
            }
        }

        private void addCmboxToUrunAdi()
        {

            var resul = urunManager.GetAll();

            foreach (var item in resul.Data)
            {
                cmbox_ürünAdı.Items.Add(item.UrunAdı);
            }
        }

        private void cmbox_ürünAdı_SelectedIndexChanged(object sender, EventArgs e)
        {
            var resul = urunManager.GetAll();

            foreach (var item in resul.Data)
            {
                if (cmbox_ürünAdı.Text == item.UrunAdı)
                {
                    txtbox_ürünkod.Text = item.UrunKodu;
                    txtbox_ürünkdv.Text = item.KDV.ToString();
                    txtbox_ürünbarkod.Text = item.Barkot;
                    txtBox_fiyat.Text = (((item.Fiyat * item.KDV) / 100) + item.Fiyat).ToString();
                }
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
            var rsltUrunGetDetails = urunManager.GetUrunDetails(txtbox_ürünkod.Text);

            Sepet sepet = new Sepet
            {
                Barkot = rsltUrunGetDetails.Data.Barkot.ToString(),
                CariNo = txtbox_cariNo.Text,//buradaki cariNo satın alacak kişinin cari nosu olmalı , stoktaki cari no ürünü aldığımız/eklediğimiz kişinin cari nosu
                Miktar = Convert.ToInt32(txtbox_miktar.Text),
                Fiyat = Convert.ToDecimal(txtBox_fiyat.Text) * Convert.ToDecimal(txtbox_miktar.Text),
                KDV = rsltUrunGetDetails.Data.KDV,
                UrunAdı = cmbox_ürünAdı.Text,
                UrunId = rsltUrunGetDetails.Data.UrunId,
                UrunKodu = rsltUrunGetDetails.Data.UrunKodu,
                UrunTipi = rsltUrunGetDetails.Data.UrunTipi,
                SatısTipi = cmbox_ödeneYöntemi.Text,
                BürütTutar = Convert.ToInt32(txtbox_miktar.Text) * rsltUrunGetDetails.Data.Fiyat,
                Aciklama = txtbox_acıklama.Text,
                BorcAlacak = ""
            };
 

            switch (cmbox_ödeneYöntemi.Text)
            {
                case "Nakit":
                    sepet.BorcAlacak = "Yok.";
                    break;
                case "Kredi Kartı":
                    sepet.BorcAlacak = "Yok.";
                    break;
                case "Borc":
                    sepet.BorcAlacak = "Borç";
                    break;
                default:
                    break;
            }

            addToListView(sepet.UrunAdı, sepet.Miktar.ToString(), sepet.Fiyat.ToString());

            sepets.Add(sepet);

            decimal toplamTutar = 0;

            for (int i = 0; i < sepets.Count; i++)
            {
                toplamTutar += toplamTutar = sepets[i].Fiyat;
            }
            lbl_toplamTutar.Text = toplamTutar.ToString();

        }

        private void btn_satış_Click(object sender, EventArgs e)
        {
            
            string faturaNo = faturaManager.CreateFaturaNoWithGUID().Message;//bir sepet için 1 adet fatura no üretir

            for (int i = 0; i < sepets.Count; i++)
            {

                var result = faturaManager.CreateSatısFatura(sepets[i],faturaNo);
                sepets[i].FaturaNo = result.Data.FaturaNo;
                //her fatura kestiğinde stokğu güncelle

                stokManager.UpdateStokQuantity(sepets[i], sepets[i].Miktar);
                stokHareket.Cikis(sepets[i]);
                cariHareketManager.BorcCreateCariHareket(result.Data.FaturaNo, sepets[i]);
               
            }
            txtbox_acıklama.Clear();
            txtbox_cariNo.Clear();
            txtBox_fiyat.Clear();
            txtbox_miktar.Text = "0";
            txtbox_ürünbarkod.Clear();
            txtbox_ürünkdv.Clear();
            txtbox_ürünkod.Clear();
            lbl_toplamTutar.Text = "0";
            cmbox_cariAd.Text = "";
            cmbox_ödeneYöntemi.Text = "";
            cmbox_ürünAdı.Text = "";
            listView1.Items.Clear();
            sepets.Clear();

            MessageBox.Show("Satış gerçekleşti.");

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txtbox_acıklama.Clear();
            txtbox_cariNo.Clear();
            txtBox_fiyat.Clear();
            txtbox_miktar.Clear();
            txtbox_ürünbarkod.Clear();
            txtbox_ürünkdv.Clear();
            txtbox_ürünkod.Clear();
            lbl_toplamTutar.Text = "0";
            cmbox_cariAd.Text = "";
            cmbox_ödeneYöntemi.Text = "";
            cmbox_ürünAdı.Text = "";
            listView1.Items.Clear();
            sepets.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtbox_miktar.Text = (Convert.ToInt32(txtbox_miktar.Text) - 1).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtbox_miktar.Text = (Convert.ToInt32(txtbox_miktar.Text) + 1).ToString();
        }
    }
}
