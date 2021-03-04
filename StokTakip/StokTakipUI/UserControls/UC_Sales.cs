using Business.Concrete;
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
        FaturaManager faturaManager = new FaturaManager(new EfFaturaDal(),new TahsilatManager(new EfTahsilatDal()),new CariHareketlerManager(new EfCariHareketDal()));
        StokManager stokManager = new StokManager(new EfStokDal());
        TahsilatManager tahsilatManager = new TahsilatManager(new EfTahsilatDal());
        CariHareketlerManager cariHareketManager = new CariHareketlerManager(new EfCariHareketDal());

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
                CariNo = rsltUrunGetDetails.Data.CariNo,
                Miktar = Convert.ToInt32(txtbox_miktar.Text),
                Fiyat = Convert.ToDecimal( txtBox_fiyat.Text) * Convert.ToDecimal(txtbox_miktar.Text),
                KDV = rsltUrunGetDetails.Data.KDV,
                UrunAdı = cmbox_ürünAdı.Text,
                UrunId = rsltUrunGetDetails.Data.UrunId,
                UrunKodu = rsltUrunGetDetails.Data.UrunKodu,              
                UrunTipi = rsltUrunGetDetails.Data.UrunTipi,
                SatısTipi = txtbox_ödemeYöntemi.Text,
                BürütTutar= Convert.ToInt32(txtbox_miktar.Text)* rsltUrunGetDetails.Data.Fiyat,
                Aciklama=txtbox_acıklama.Text,
                BorcAlacak=""
            };
         
            addToListView(sepet.UrunAdı, sepet.Miktar.ToString(), sepet.Fiyat.ToString());

            sepets.Add(sepet);

            decimal toplamTutar=0;

            for (int i = 0; i < sepets.Count; i++)
            {
                toplamTutar += toplamTutar = sepets[i].Fiyat;
            }
            lbl_toplamTutar.Text = toplamTutar.ToString();


            

        }

        private void btn_satış_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < sepets.Count; i++)
            {
                faturaManager.CreateFatura(sepets[i]);
            }
            
        }
    }
}
