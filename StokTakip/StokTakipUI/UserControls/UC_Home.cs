using Business.Concrete;
using DataAcces.Concrete;
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

namespace StokTakipUI.UserControls
{
    public partial class UC_Home : UserControl
    {
        CariManager cariManager = new CariManager(new EfCariDal());
        FaturaManager faturaManager = new FaturaManager(new EfFaturaDal(),  new CariHareketlerManager(new EfCariHareketDal()));
        public UC_Home()
        {
            InitializeComponent();
            reflashDashBoards();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Random random = new Random();
            //lbl_toplamSatısTutar.Text = random.Next(0, 100).ToString();
            //lbl_satıs.Text=random.Next(0, 100).ToString();
            //lbl_cariSayısı.Text = random.Next(0, 100).ToString();
            reflashDashBoards();
        }
        private void AddControlsToPanel(Control c)
        {
           
            
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            reflashDashBoards();
        }
        private void reflashDashBoards()
        {
            //satıs
            lbl_satıs.Text = faturaManager.getTotalSellCount().Data.ToString();
            lbl_toplamSatısTutar.Text = faturaManager.getFaturaGenelToplam().Data.ToString();
            lbl_cariSayısı.Text = cariManager.totalCariCount().Data.ToString();

            //alış
            lbl_toplamAlışTutarı.Text = faturaManager.getFaturaAlışGenelToplam().Data.ToString();
            lbl_toplamAlışMiktarı.Text = faturaManager.getTotalBuyCount().Data.ToString();
        }
    }
}
