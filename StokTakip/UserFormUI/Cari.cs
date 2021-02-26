using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Concrete;
using DataAcces.Concrete.EntityFramework;

namespace UserFormUI
{
    public partial class Cari : Form
    {
        CariManager cariManager = new CariManager(new EfCariDal());
        public Cari()
        {
            InitializeComponent();
        }

        private void Cari_Load(object sender, EventArgs e)
        {
            RefleshDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            cariManager.Add(new Entity.Concrete.Cari
            {
                CariAdres = txtBox_adress.Text,
                CariAdı = txtBox_cariAd.Text,
                CariIl = txtBox_cariIl.Text,
                CariIlce=txtBox_cariİlce.Text,
                CariNo=txtBox_cariNo.Text,
                Eposta=txtBox_eposta.Text,
                TcKimlikNo=txtBox_tckimlikNo.Text,
                Telefon=txtBox_telefon.Text,
                VergiDairesi=txtBox_vergiDairesi.Text,
                VergiNo=txtBox_vergiNumarası.Text,                
            });
            RefleshDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBox_cariID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBox_cariNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBox_cariAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtBox_adress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtBox_cariIl.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtBox_cariİlce.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtBox_vergiDairesi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtBox_vergiNumarası.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtBox_tckimlikNo.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtBox_telefon.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtBox_eposta.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void RefleshDataGridView()
        {
            var result = cariManager.GetAll();
            dataGridView1.DataSource = result.Data;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = cariManager.Search(new Entity.Concrete.Cari
            {
                CariId = Convert.ToInt32(txtBox_cariID.Text),
                CariAdres = txtBox_adress.Text,
                CariAdı = txtBox_cariAd.Text,
                CariIl = txtBox_cariIl.Text,
                CariIlce = txtBox_cariİlce.Text,
                CariNo = txtBox_cariNo.Text,
                Eposta = txtBox_eposta.Text,
                TcKimlikNo = txtBox_tckimlikNo.Text,
                Telefon = txtBox_telefon.Text,
                VergiDairesi = txtBox_vergiDairesi.Text,
                VergiNo = txtBox_vergiNumarası.Text,
            });

            // var rslt=  cariManager.Search(new Entity.Concrete.Cari { CariNo = "2"});
            dataGridView1.DataSource = result.Data;

            //RefleshDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = cariManager.Update(new Entity.Concrete.Cari
            {
                CariId = Convert.ToInt32(txtBox_cariID.Text),
                CariAdres = txtBox_adress.Text,
                CariAdı = txtBox_cariAd.Text,
                CariIl = txtBox_cariIl.Text,
                CariIlce = txtBox_cariİlce.Text,
                CariNo = txtBox_cariNo.Text,
                Eposta = txtBox_eposta.Text,
                TcKimlikNo = txtBox_tckimlikNo.Text,
                Telefon = txtBox_telefon.Text,
                VergiDairesi = txtBox_vergiDairesi.Text,
                VergiNo = txtBox_vergiNumarası.Text,
            });

            RefleshDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             cariManager.Delete(new Entity.Concrete.Cari
            {
                CariId = Convert.ToInt32(txtBox_cariID.Text),
                CariAdres = txtBox_adress.Text,
                CariAdı = txtBox_cariAd.Text,
                CariIl = txtBox_cariIl.Text,
                CariIlce = txtBox_cariİlce.Text,
                CariNo = txtBox_cariNo.Text,
                Eposta = txtBox_eposta.Text,
                TcKimlikNo = txtBox_tckimlikNo.Text,
                Telefon = txtBox_telefon.Text,
                VergiDairesi = txtBox_vergiDairesi.Text,
                VergiNo = txtBox_vergiNumarası.Text,
            });

            RefleshDataGridView();
        }
    }
}
